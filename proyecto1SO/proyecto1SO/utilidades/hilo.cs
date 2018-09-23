using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public enum estadoProceso
    {
        bloqueado,
        noBloqueado
    }
    public class hilo
    {
        private static Mutex mutexOper = new Mutex();
        public Config configuracion;
        public List<Mensaje> lstMensajes; //aqui llegan los que hay que enviar
        public List<Mensaje> lstMensajesRecibidos;
        public estadoProceso estado;
        public int idProceso;
        public bool send;
        public bool receive;

        public hilo(int idProceso, Config configuracion)
        {
            this.idProceso = idProceso;
            lstMensajes = new List<Mensaje>();
            lstMensajesRecibidos = new List<Mensaje>();
            estado = estadoProceso.noBloqueado;
            send = true;
            receive = false;
            this.configuracion = configuracion;
        }

        public void bloquear()
        {
            estado = estadoProceso.bloqueado;
        }
        public void desbloquear()
        {
            estado = estadoProceso.noBloqueado;
        }
        public void establecerSend()
        {
            send = true;
            receive = false;
        }
        public void establecerReceive()
        {
            send = false;
            receive = true;
        }
        public void ejecutar()
        {

            while(true)
            {
                Thread.Sleep(2000);
                mutexOper.WaitOne();
                //seccion critica
                // verificar si hay mensajes y no esta bloqueado
                if (lstMensajes.Count>0 && estado == estadoProceso.noBloqueado)
                {//verificar disciplina de la cola
                    if(configuracion.colas.FIFO)
                    {//disciplina fifo
                        if(lstMensajes[0].TipoMsg == tipoMensaje.send)
                        {//es un send
                            if(configuracion.direccionamiento.Directo)
                            {//direcionamiento directo
                                if(configuracion.sincronizacion.send.blocking)
                                {// blocking
                                    bloquear();
                                    procesos.lstProcesos[lstMensajes[0].idDestino].lstMensajesRecibidos.Add(lstMensajes[0]);
                                    lstMensajes.RemoveAt(0);
                                    using (System.IO.StreamWriter escritor = new System.IO.StreamWriter("Prueba.txt"))//para ver si lo hizo, se puede quitar
                                    {
                                        escritor.WriteLine("origen: "+ lstMensajes[0].idOrigen +" destino "+ lstMensajes[0].idDestino +" contenido: " + lstMensajes[0].Contenido);
                                    }
                                    desbloquear();
                                }
                                else
                                {//no blocking
                                    procesos.lstProcesos[lstMensajes[0].idDestino].lstMensajesRecibidos.Add(lstMensajes[0]);
                                    using (System.IO.StreamWriter escritor = new System.IO.StreamWriter("Prueba.txt"))
                                    {
                                        escritor.WriteLine("origen: " + lstMensajes[0].idOrigen + " destino " + lstMensajes[0].idDestino + " contenido: " + lstMensajes[0].Contenido);
                                    }
                                }
                            }
                            else
                            {//send direccionamiento indirecto
                                if (configuracion.sincronizacion.send.blocking)
                                {//bloking
                                    bloquear();
                                    //buscar en buzon
                                    if(procesos.MailBox[this.idProceso].lstMensajes.Count>0)
                                    {//han llegado mensajes
                                        //procesos.lstProcesos[procesos.MailBox[this.idProceso].lstMensajes[0].idDestino].lstMensajes
                                    }
                                    desbloquear();

                                }
                                else
                                {//no bloking

                                }

                            }
                        }
                        else
                        {//es un receive

                        }

                    }
                    else
                    {//disciplina por prioridad

                    }
                }
                mutexOper.ReleaseMutex();
            }
        }

    }
}
