using System;
using System.Collections.Generic;
using System.IO;
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
        public List<string> log;
        public hilo(int idProceso, Config configuracion)
        {
            this.idProceso = idProceso;
            lstMensajes = new List<Mensaje>();
            lstMensajesRecibidos = new List<Mensaje>();
            estado = estadoProceso.noBloqueado;
            send = true;
            receive = false;
            this.configuracion = configuracion;
            log = new List<string>();
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

        public Mensaje obtenerPrioridad()
        {
            mutexOper.WaitOne();
            int aux;
            aux = -1;
            Mensaje msg = new Mensaje();
 
                foreach (var item in lstMensajes)
                {
                   
                        if(aux<item.prioridad)
                        {
                            msg.Contenido = item.Contenido;
                            msg.idDestino = item.idDestino;
                            msg.idOrigen = item.idOrigen;
                            msg.prioridad = item.prioridad;
                            msg.Tamanio = item.Tamanio;
                            msg.TipoMsg = item.TipoMsg;
                        }
                   
                }
                 
            
            lstMensajes.Remove(msg);
            mutexOper.ReleaseMutex();
            return msg;
        }

        public void ejecutar(object pParametros)
        {
            
            while (true)
            {
                Thread.Sleep(2000);
                if (this.estado == estadoProceso.noBloqueado)
                {
                    if (configuracion.direccionamiento.tipo == 0) // tipo: 0=directo, 1=indirecto
                    {//direccionamiento directo

                        if (configuracion.colas.FIFO)
                        {//direccionamiento directo, disciplina fifo
                            if (lstMensajes.Count > 0)
                            {
                                if (lstMensajes[0].TipoMsg == tipoMensaje.send)
                                {//direccionamiento directo, disciplina fifo, send
                                    if (configuracion.sincronizacion.send.blocking)
                                    {// blocking
                                        bloquear();
                                        mutexOper.WaitOne();
                                        procesos.lstProcesos[lstMensajes[0].idDestino].lstMensajesRecibidos.Add(lstMensajes[0]);
                                        StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
                                        WriteReportFile.WriteLine("send directo, blocking, fifo, origen: " + lstMensajes[0].idOrigen + " destino " + lstMensajes[0].idDestino + " contenido: " + lstMensajes[0].Contenido);
                                        WriteReportFile.Close();

                                        lstMensajes.RemoveAt(0);
                                        desbloquear();
                                        mutexOper.ReleaseMutex();
                                    }
                                    else
                                    {//no blocking
                                        mutexOper.WaitOne();
                                        procesos.lstProcesos[lstMensajes[0].idDestino].lstMensajesRecibidos.Add(lstMensajes[0]);
                                        StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
                                        WriteReportFile.WriteLine("send directo, no bloquing, fifo, origen: " + lstMensajes[0].idOrigen + " destino " + lstMensajes[0].idDestino + " contenido: " + lstMensajes[0].Contenido);
                                        WriteReportFile.Close();

                                        lstMensajes.RemoveAt(0);
                                        mutexOper.ReleaseMutex();
                                    }
                                }
                                else
                                {//direccionamiento directo, disciplina fifo, receive
                                    bloquear();
                                    mutexOper.WaitOne();
                                    procesos.lstProcesos[lstMensajes[0].idDestino].lstMensajesRecibidos.Add(lstMensajes[0]);
                                    StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
                                    WriteReportFile.WriteLine("send directo, blocking, fifo origen: " + lstMensajes[0].idOrigen + " destino " + lstMensajes[0].idDestino + " contenido: " + lstMensajes[0].Contenido);
                                    WriteReportFile.Close();
                                    lstMensajes.RemoveAt(0);
                                    desbloquear();
                                    mutexOper.ReleaseMutex();
                                }
                            }
                        }
                        else
                        {// direccionamiento directo, disciplina prioridad
                            if (lstMensajes.Count > 0)
                            {
                                //obtener prioridad
                                
                                Mensaje msg = obtenerPrioridad();
                                if(msg.idDestino !=idProceso)
                                {
                                    if (msg.TipoMsg == tipoMensaje.send)
                                    {
                                        if (configuracion.sincronizacion.send.blocking)
                                        {
                                            bloquear();
                                            mutexOper.WaitOne();
                                            procesos.lstProcesos[msg.idDestino].lstMensajesRecibidos.Add(msg);
                                            StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
                                            WriteReportFile.WriteLine("send directo, modo blocking, por prioridad, origen: " + msg.idOrigen + " destino " + msg.idDestino + " contenido: " + msg.Contenido);
                                            WriteReportFile.Close();
                                            lstMensajes.RemoveAt(0);
                                            desbloquear();
                                            mutexOper.ReleaseMutex();
                                        }
                                        else
                                        {
                                            mutexOper.WaitOne();
                                            procesos.lstProcesos[msg.idDestino].lstMensajesRecibidos.Add(msg);
                                            StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
                                            WriteReportFile.WriteLine("send directo, blocking, por prioridad origen: " + msg.idOrigen + " destino " + msg.idDestino + " contenido: " + msg.Contenido);
                                            WriteReportFile.Close();
                                            lstMensajes.RemoveAt(0);
                                            mutexOper.ReleaseMutex();
                                        }
                                    }
                                    else
                                    {
                                        
                                    }
                                }
                                else
                                {
                                    mutexOper.WaitOne();
                                    procesos.lstProcesos[idProceso].lstMensajesRecibidos.Add(msg);
                                    procesos.MailBox[idProceso].lstMensajes.Remove(msg);
                                    mutexOper.ReleaseMutex();
                                }
                             
                                
                            }
                        }
                    }
                    else
                    {//direccionamiento indirecto

                        if (configuracion.colas.FIFO)
                        {//direccionamiento indirecto, disciplina fifo                             
                            mutexOper.WaitOne();
                            if (procesos.MailBox[this.idProceso].lstMensajes.Count > 0)
                            {
                                if (procesos.MailBox[this.idProceso].lstMensajes[0].TipoMsg == tipoMensaje.send)
                                {//direccionamiento indirecto, disciplina fifo, tipo send
                                    mutexOper.ReleaseMutex();
                                    if (configuracion.sincronizacion.send.blocking)
                                    {//direcionamiento indirecto, disciplina fifo, blocking
                                        bloquear();
                                        mutexOper.WaitOne();
                                        Mensaje msg = procesos.MailBox[this.idProceso].lstMensajes[0];
                                        procesos.MailBox[this.idProceso].lstMensajes.RemoveAt(0);
                                        procesos.lstProcesos[msg.idDestino].lstMensajesRecibidos.Add(msg);
                                        desbloquear();
                                        StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
                                        WriteReportFile.WriteLine("send indirecto blocking origen: " + msg.idOrigen + " destino " + msg.idDestino + " contenido: " + msg.Contenido);
                                        WriteReportFile.Close();
                                        mutexOper.ReleaseMutex();
                                    }
                                    else
                                    {
                                        mutexOper.WaitOne();
                                        Mensaje msg = procesos.MailBox[this.idProceso].lstMensajes[0];
                                        procesos.MailBox[this.idProceso].lstMensajes.RemoveAt(0);
                                        procesos.lstProcesos[msg.idDestino].lstMensajesRecibidos.Add(msg);
                                        StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
                                        WriteReportFile.WriteLine("send indirecto no blocking origen: " + msg.idOrigen + " destino " + msg.idDestino + " contenido: " + msg.Contenido);
                                        WriteReportFile.Close();
                                        mutexOper.ReleaseMutex();
                                    }
                                }
                                else
                                {//direccionamiento indirecto, disciplina fifo, tipo receive
                                }
                            }
                        }
                        else
                        {//direccionamiento indirecto, disciplina prioridad
                            mutexOper.WaitOne();
                            if (procesos.MailBox[this.idProceso].lstMensajes.Count > 0)
                            {
                                mutexOper.ReleaseMutex();
                                Mensaje msg = obtenerPrioridad();
                                if(msg.idDestino!=idProceso)
                                {
                                    if (msg.TipoMsg == tipoMensaje.send)
                                    {//direccionamiento indirecto, tipo prioridad, send
                                        if (configuracion.sincronizacion.send.blocking)
                                        {//blocking
                                            bloquear();
                                            mutexOper.WaitOne();
                                            procesos.MailBox[msg.idDestino].lstMensajes.Add(msg);//se envia al buzon
                                            mutexOper.ReleaseMutex();
                                            bool esperar = true;
                                            while (esperar)
                                            {
                                                mutexOper.WaitOne();
                                                if (procesos.MailBox[msg.idDestino].lstMensajes.Count == 0)
                                                    esperar = false;
                                                mutexOper.ReleaseMutex();
                                            }
                                            desbloquear();
                                        }
                                        else
                                        {//no blocking
                                            mutexOper.WaitOne();
                                            procesos.MailBox[msg.idDestino].lstMensajes.Add(msg);//se envia al buzon
                                            mutexOper.ReleaseMutex();
                                        }
                                    }
                                    else
                                    {//direccionamiento indirecto, tipo prioridad, receive
                                        if (configuracion.sincronizacion.send.blocking)
                                        {
                                            bloquear();

                                            desbloquear();
                                        }
                                        else
                                        {

                                        }
                                    }
                                }
                                else
                                {
                                    mutexOper.WaitOne();
                                    procesos.lstProcesos[idProceso].lstMensajesRecibidos.Add(msg);
                                    procesos.MailBox[idProceso].lstMensajes.Remove(msg);
                                    mutexOper.ReleaseMutex();
                                }

                                
                            }
                        }
                    }
                }

            }
        }
    }
}