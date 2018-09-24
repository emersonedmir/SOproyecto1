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
        public void ejecutar(object pParametros)
        {
            //    string[] parametros = (string[])pParametros;
            //    int idx_hilo = Convert.ToInt32(parametros[0]);
            //    int t_id = Convert.ToInt32(parametros[1]);
            //    string t_name = parametros[2];
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
                                        WriteReportFile.WriteLine("send directo blocking origen: " + lstMensajes[0].idOrigen + " destino " + lstMensajes[0].idDestino + " contenido: " + lstMensajes[0].Contenido);
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
                                        WriteReportFile.WriteLine("send directo no bloquing origen: " + lstMensajes[0].idOrigen + " destino " + lstMensajes[0].idDestino + " contenido: " + lstMensajes[0].Contenido);
                                        WriteReportFile.Close();

                                        lstMensajes.RemoveAt(0);
                                        mutexOper.ReleaseMutex();
                                    }
                                }
                                else
                                {//direccionamiento directo, disciplina fifo, receive

                                }
                            }
                        }
                        else
                        {//direccionamiento directo, disciplina prioridad
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
                        }
                    }
                }

            }
        }
    }
}