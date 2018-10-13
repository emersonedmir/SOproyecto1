using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1SO.utilidades
{
    public enum estadoProceso
    {
        bloqueado,
        noBloqueado,
        busyWaiting
    }
    public class hilo
    {
        //control block variables
        private static Mutex mutexOper = new Mutex();
        private static Mutex mutexGetMen = new Mutex();
        public Config configuracion;
        public List<Mensaje> lstMensajes; //aqui llegan los que hay que enviar a otros procesos o entrar en espera receive
        public List<Mensaje> lstMensajesRecibidos; //aqui quedan los mensajes que recibe el proceso de otros
        public estadoProceso estado;
        public int idProceso;
        public bool send;
        public bool receive;
        public List<Log> ltsLog; //para guardar los logs
        public List<string> log; //para guardar los logs
        public hilo(int idProceso, Config configuracion)
        {
            this.idProceso = idProceso;
            lstMensajes = new List<Mensaje>();
            lstMensajesRecibidos = new List<Mensaje>();
            estado = estadoProceso.noBloqueado;
            send = true;
            receive = false;
            this.configuracion = configuracion;
            ltsLog = new List<Log>();
            log = new List<string>();
        }
        public override String ToString()
        {
            string procStr = "Proceso: " + idProceso.ToString() + '\n';
            foreach (var item in ltsLog)
            {
                procStr += '\t' + item.ToString() + '\n';
            }
            if (configuracion.direccionamiento.tipo == 0)
                procStr += BufferToString();
            return procStr;
        }
        public String BufferToString()
        {
            string strBuffer = "\tBuffer de comandos:\n";
            strBuffer += "\tLargo: " + lstMensajes.Count.ToString() + '\n';
            strBuffer += "\tCola de recibidos:\n";
            strBuffer += "\tLargo: " + lstMensajesRecibidos.Count.ToString() + '\n';
            foreach (var item in lstMensajesRecibidos)
                strBuffer += "\t\t" + item.ToString() + "\n";
            return strBuffer;
        }

        public void estadoBloqueo()
        {
            switch (estado)
            {
                case estadoProceso.bloqueado:
                    {
                        StreamWriter WriteReportFile = File.AppendText("estadosProcesos.txt");
                        string historia = "Proceso " + idProceso.ToString() + " bloqueado";
                        WriteReportFile.WriteLine(historia);
                        WriteReportFile.Close();
                        break;

                    }
                case estadoProceso.noBloqueado:
                    {
                        StreamWriter WriteReportFile = File.AppendText("estadosProcesos.txt");
                        string historia = "Proceso " + idProceso.ToString() + " no bloqueado";
                        WriteReportFile.WriteLine(historia);
                        WriteReportFile.Close();
                        break;
                    }
                case estadoProceso.busyWaiting:
                    {
                        StreamWriter WriteReportFile = File.AppendText("estadosProcesos.txt");
                        string historia = "Proceso " + idProceso.ToString() + " no bloqueado (busy waiting)";
                        WriteReportFile.WriteLine(historia);
                        WriteReportFile.Close();
                        break;
                    }
            }
        }

        public void bloquear()
        {
            estado = estadoProceso.bloqueado;
        }
        public void desbloquear()
        {
            estado = estadoProceso.noBloqueado;
        }
        public void bloquearBW()
        {
            estado = estadoProceso.busyWaiting;
        }
        //public void establecerSend()
        //{
        //    send = true;
        //    receive = false;
        //}
        //public void establecerReceive()
        //{
        //    send = false;
        //    receive = true;
        //}
        //public Mensaje obtenerPrioridad()
        //{
        //    mutexOper.WaitOne();
        //    int aux;
        //    aux = -1;
        //    Mensaje msg = new Mensaje();

        //        foreach (var item in lstMensajes)
        //        {                
        //                if(aux<item.prioridad)
        //                {
        //                    msg.Contenido = item.Contenido;
        //                    msg.idDestino = item.idDestino;
        //                    msg.idOrigen = item.idOrigen;
        //                    msg.prioridad = item.prioridad;
        //                    msg.Tamanio = item.Tamanio;
        //                    msg.TipoMsg = item.TipoMsg;
        //                }

        //        }


        //    lstMensajes.Remove(msg);
        //    mutexOper.ReleaseMutex();
        //    return msg;
        //}
        public Mensaje obtenerMenRecibido(int origen)
        {
            mutexOper.WaitOne();
            int aux;
            aux = -1;
            Mensaje msg = null;
            if (configuracion.direccionamiento.tipo == 0)
            {
                foreach (var item in lstMensajesRecibidos)
                {
                    if ((item.idOrigen == origen) || (-1 == origen))
                    {
                        if (configuracion.colas.Prioridad)
                        {
                            if (aux < item.prioridad)
                            {
                                aux = item.prioridad;
                                msg = item;
                            }
                        }
                        else //FIFO
                        {
                            msg = item;
                            break;
                        }
                    }
                }
                if (msg != null)
                    lstMensajes.Remove(msg);
            }
            else
            {
                int puerto;
                if (configuracion.direccionamiento.indirecto.estatico)
                    puerto = configuracion.confProceso.puertosReceptor[idProceso];
                else
                    puerto = origen;
                int idx = puertos.Get_IdxMailBox(puerto);
                Mensaje msgAux = null;
                foreach (var item in puertos.lstMailBox[idx].lstMensajes)
                {
                    if ((item.idDestino == puerto) || (item.idOrigen != puerto))
                    {
                        if (configuracion.colas.Prioridad)
                        {
                            if (aux < item.prioridad)
                            {
                                aux = item.prioridad;
                                msgAux = item;
                            }
                        }
                        else //FIFO
                        {
                            msgAux = item;
                            break;
                        }
                    }
                }
                msg = msgAux;
                if (msg != null)
                    puertos.lstMailBox[idx].lstMensajes.Remove(msg);
            }
            mutexOper.ReleaseMutex();
            return msg;
        }        

        public void documentar(Mensaje msg)
        {
            string direccionamiento = string.Empty;
            string tipoDireccionamiento = string.Empty;
            string colaPrioridad = string.Empty;
            string bloqueo = string.Empty;

            if (configuracion.direccionamiento.tipo == 0) { direccionamiento = "directo "; } else { direccionamiento = "indirecto "; }
            if (msg.TipoMsg == tipoMensaje.send) { tipoDireccionamiento = "send "; } else { tipoDireccionamiento = "receive "; }
            if (configuracion.colas.FIFO) { colaPrioridad = "FIFO "; } else { colaPrioridad = "Prioridad "; }
            if (configuracion.sincronizacion.send.blocking || configuracion.sincronizacion.receive.blocking)
            { bloqueo = " blocking"; }
            else if (configuracion.sincronizacion.send.nonblocking || configuracion.sincronizacion.receive.nonblocking)
            { bloqueo = " no bloking"; }

            StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
            string historia = "direccionamiento: " + direccionamiento + ", Tipo mensaje: " + tipoDireccionamiento + "Tipo cola: " + colaPrioridad + ", Origen:" + msg.idOrigen + " destino " + msg.idDestino + " contenido: " + msg.Contenido + ", procesado";
            WriteReportFile.WriteLine(historia);
            WriteReportFile.Close();
            lstMensajes.Remove(msg);
            log.Add(historia);
        }
        //public void verificarBuzon()
        //{
        //    mutexOper.WaitOne();
        //    if (puertos.lstMailBox[idProceso].lstMensajes.Count > 0)
        //    {
        //        puertos.lstMailBox[idProceso].lstMensajes.Clear();
        //    }
        //    mutexOper.ReleaseMutex();
        //}
        private Mensaje Get_mensaje_proceso()
        {
            Mensaje mensaje = null;
            if (configuracion.direccionamiento.tipo == 0)
            {
                if (lstMensajes.Count > 0) {
                    mutexGetMen.WaitOne();
                    //Los procesos se seleccionan siempre en FIFO -> mensaje:{send|receive}
                    mensaje = lstMensajes[0];
                    lstMensajes.Remove(mensaje);
                    mutexGetMen.ReleaseMutex();
                }                
            }
            else if ((configuracion.direccionamiento.tipo == 1) && (configuracion.direccionamiento.indirecto.dinamico))
            {
                if (procesosDDin.lstProcesosDDin.Count > 0)
                {
                    mutexGetMen.WaitOne();
                    //Los procesos se seleccionan siempre en FIFO -> mensaje:{send|receive}
                    mensaje = procesosDDin.lstProcesosDDin[0];
                    procesosDDin.lstProcesosDDin.Remove(mensaje);
                    mutexGetMen.ReleaseMutex();
                }
            }
            else
            {
                if (procesosDDin.lstProcesosDDin.Count > 0)
                {
                    int puertoR = configuracion.confProceso.puertosReceptor[idProceso];
                    mutexGetMen.WaitOne();
                    //Los procesos se seleccionan siempre en FIFO -> mensaje:{send|receive}                    
                    for (int i = 0; i < procesosDDin.lstProcesosDDin.Count; i++) {
                        if (procesosDDin.lstProcesosDDin[i].TipoMsg == tipoMensaje.send)
                        {
                            mensaje = procesosDDin.lstProcesosDDin[i];
                            break;
                        }
                        else if (procesosDDin.lstProcesosDDin[i].idDestino == puertoR)
                        {
                            mensaje = procesosDDin.lstProcesosDDin[i];
                            break;
                        }
                    }
                    if (mensaje != null)
                        procesosDDin.lstProcesosDDin.Remove(mensaje);
                    mutexGetMen.ReleaseMutex();
                }
            }
            return mensaje;
        }
        public void ejecutar(object pParametros)
        {
            Mensaje mensaje = null;
            while (true)
            {
                Thread.Sleep(1000);
                if (this.estado == estadoProceso.noBloqueado)
                {
                    mensaje = Get_mensaje_proceso();
                    if (mensaje != null)
                    {                        
                        if (configuracion.direccionamiento.tipo == 0) // tipo: 0=directo, 1=indirecto
                        {//direccionamiento directo                            
                            if (mensaje.TipoMsg == tipoMensaje.send)
                            {//direccionamiento directo, disciplina fifo, send
                                ltsLog.Add(new Log(idProceso.ToString(), "recibe solicitud de realizar send al proceso " + mensaje.idDestino.ToString()));                                
                                if (configuracion.sincronizacion.send.blocking)
                                {// blocking                                                                        
                                    bloquear();
                                    mutexOper.WaitOne();
                                    procesos.lstProcesos[mensaje.idDestino].lstMensajesRecibidos.Add(mensaje);
                                    documentar(mensaje);
                                    //desbloquear(); no desbloquear hasta obtener respuesta
                                    mutexOper.ReleaseMutex();
                                    ltsLog.Add(new Log(idProceso.ToString(), mensaje));
                                    ltsLog.Add(new Log(idProceso.ToString(), "proceso bloqueado en espera de confirmación"));
                                }
                                else
                                {//no blocking
                                    mutexOper.WaitOne();
                                    procesos.lstProcesos[mensaje.idDestino].lstMensajesRecibidos.Add(mensaje);
                                    documentar(mensaje);
                                    mutexOper.ReleaseMutex();
                                    ltsLog.Add(new Log(idProceso.ToString(), mensaje));                                    
                                }
                            }
                            else // Receive
                            {// del buffer de entrada obtener mensaje de un emisor en especifico o emisor -1
                                ltsLog.Add(new Log(idProceso.ToString(), "recibe solicitud de realizar receive al proceso " + mensaje.idDestino.ToString()));
                                bool encontrado = false;
                                Mensaje mensajeRecibido = null;
                                if (configuracion.sincronizacion.receive.blocking)
                                {
                                    bloquear();                                    
                                    ltsLog.Add(new Log(idProceso.ToString(), "proceso bloqueado en espera de recepción"));
                                    while (!encontrado)
                                    {
                                        mensajeRecibido = obtenerMenRecibido(mensaje.idOrigen);  //Origen=-1 -> recibe implisito
                                        encontrado = (mensajeRecibido != null);
                                        if (!encontrado)
                                        {
                                            Thread.Sleep(500);
                                        }
                                    }                                    
                                    desbloquear();
                                    ltsLog.Add(new Log(idProceso.ToString(), "proceso desbloqueado"));
                                    ltsLog.Add(new Log(idProceso.ToString(), mensajeRecibido));
                                }
                                else if (configuracion.sincronizacion.receive.nonblocking)
                                {
                                    mensajeRecibido = obtenerMenRecibido(mensaje.idOrigen);  //Origen=-1 -> recibe implisito
                                    encontrado = (mensajeRecibido != null);
                                    if (encontrado)
                                        ltsLog.Add(new Log(idProceso.ToString(), mensajeRecibido));
                                    else
                                        ltsLog.Add(new Log(idProceso.ToString(), "no hay mensajes por recibir"));
                                }
                                else
                                {//prueba de llegada                                       
                                    bloquearBW();
                                    ltsLog.Add(new Log(idProceso.ToString(), "proceso en estado busyWating en espera de recepción"));
                                    while (!encontrado)
                                    {
                                        mensajeRecibido = obtenerMenRecibido(mensaje.idOrigen);  //Origen=-1 -> recibe implisito
                                        encontrado = (mensajeRecibido != null);
                                        if (!encontrado)
                                        {
                                            Thread.Sleep(500);
                                        }
                                    }
                                    ltsLog.Add(new Log(idProceso.ToString(), mensajeRecibido));
                                    desbloquear();                                    
                                }
                                if (encontrado)
                                {
                                    documentar(mensajeRecibido);
                                    if (configuracion.sincronizacion.send.blocking)
                                    {
                                        procesos.lstProcesos[mensajeRecibido.idOrigen].desbloquear();
                                        procesos.lstProcesos[mensajeRecibido.idOrigen].ltsLog.Add(new Log(mensajeRecibido.idOrigen.ToString(), "proceso desbloqueado, se obtuvo confirmación"));
                                    }                                        
                                }
                                else
                                {
                                    StreamWriter WriteReportFile2 = File.AppendText("Prueba.txt");
                                    string historia = "Mensaje no encontrado";
                                    WriteReportFile2.WriteLine(historia);
                                    WriteReportFile2.Close();
                                }
                                //log recibido | no recibido
                            }
                        }
                        else
                        {//direccionamiento indirecto
                            if (mensaje.TipoMsg == tipoMensaje.send)
                            {//direccionamiento directo, disciplina fifo, send
                                ltsLog.Add(new Log(idProceso.ToString(), "recibe solicitud de realizar send al puerto: " + mensaje.idDestino));
                                if (configuracion.sincronizacion.send.blocking)
                                {// blocking
                                    bloquear();
                                    mutexOper.WaitOne();
                                    int idx = puertos.Get_IdxMailBox(mensaje.idDestino);
                                    puertos.lstMailBox[idx].lstMensajes.Add(mensaje);
                                    mutexOper.ReleaseMutex();
                                    documentar(mensaje);
                                    bool respuesta = false;
                                    ltsLog.Add(new Log(idProceso.ToString(), mensaje));
                                    ltsLog.Add(new Log(idProceso.ToString(), "proceso bloqueado en espera de confirmación del mensaje"));
                                    while (!respuesta)
                                    {
                                        mutexOper.WaitOne();
                                        idx = puertos.Get_IdxMailBox(mensaje.idOrigen);
                                        if (puertos.lstMailBox[idx].lstMensajes.IndexOf(mensaje) >= 0)
                                        {
                                            respuesta = true;
                                            puertos.lstMailBox[idx].lstMensajes.Remove(mensaje);
                                            desbloquear();
                                        }
                                        mutexOper.ReleaseMutex();
                                    }
                                    ltsLog.Add(new Log(idProceso.ToString(), "proceso desbloqueado, se obtuvo confirmación en puerto: " + mensaje.idOrigen.ToString()));
                                }
                                else if (configuracion.sincronizacion.send.nonblocking)
                                {//no blocking
                                    mutexOper.WaitOne();
                                    int idx = puertos.Get_IdxMailBox(mensaje.idDestino);
                                    puertos.lstMailBox[idx].lstMensajes.Add(mensaje);
                                    ltsLog.Add(new Log(idProceso.ToString(), mensaje));
                                    mutexOper.ReleaseMutex();
                                    documentar(mensaje);
                                }                                
                            }
                            // Receive
                            else
                            {// obtener algun mensaje dejado en puerto receptor
                                ltsLog.Add(new Log(idProceso.ToString(), "recibe solicitud de realizar receive al puerto " + mensaje.idDestino.ToString()));
                                bool encontrado = false;
                                Mensaje mensajeRecibido = null;                               
                                if (configuracion.sincronizacion.receive.blocking)
                                {
                                    bloquear();
                                    if (configuracion.direccionamiento.indirecto.estatico)
                                    {
                                        int puer = configuracion.confProceso.puertosReceptor[idProceso];
                                        ltsLog.Add(new Log(idProceso.ToString(), "proceso bloqueado en espera de recepción en puerto: " + puer.ToString()));
                                    }
                                    else
                                        ltsLog.Add(new Log(idProceso.ToString(), "proceso bloqueado en espera de recepción"));
                                    while (!encontrado)
                                    {
                                        mensajeRecibido = obtenerMenRecibido(mensaje.idDestino);  //Origen=-1 -> recibe implisito
                                        encontrado = (mensajeRecibido != null);
                                        if (!encontrado)
                                        {
                                            Thread.Sleep(500);
                                        }
                                    }                                    
                                    ltsLog.Add(new Log(idProceso.ToString(), mensajeRecibido));
                                    ltsLog.Add(new Log(idProceso.ToString(), "proceso desbloqueado"));
                                    desbloquear();
                                }
                                else if (configuracion.sincronizacion.receive.nonblocking)
                                {
                                    mensajeRecibido = obtenerMenRecibido(mensaje.idDestino);  //Origen=-1 -> recibe implisito
                                    encontrado = (mensajeRecibido != null);
                                    if (encontrado)
                                        ltsLog.Add(new Log(idProceso.ToString(), mensajeRecibido));
                                    else
                                        ltsLog.Add(new Log(idProceso.ToString(), "no hay mensajes por recibir en puerto: " + mensaje.idDestino.ToString()));
                                }
                                else
                                {//prueba de llegada                                       
                                    bloquearBW();
                                    if (configuracion.direccionamiento.indirecto.estatico)
                                    {
                                        int puer = configuracion.confProceso.puertosReceptor[idProceso];
                                        ltsLog.Add(new Log(idProceso.ToString(), "proceso ejecitando busyWating en espera de recepción en puerto: " + puer.ToString()));
                                    }
                                    else
                                        ltsLog.Add(new Log(idProceso.ToString(), "proceso ejecitando busyWating en espera de recepción"));
                                    while (!encontrado)
                                    {
                                        mensajeRecibido = obtenerMenRecibido(mensaje.idDestino);  //Origen=-1 -> recibe implisito
                                        encontrado = (mensajeRecibido != null);
                                        if (!encontrado)
                                        {
                                            Thread.Sleep(500);
                                        }
                                    }
                                    ltsLog.Add(new Log(idProceso.ToString(), mensajeRecibido));
                                    ltsLog.Add(new Log(idProceso.ToString(), "proceso desbloqueado"));
                                    desbloquear();
                                }
                                if (encontrado)
                                {
                                    documentar(mensajeRecibido);
                                    if (configuracion.sincronizacion.send.blocking)
                                    {
                                        int idx = puertos.Get_IdxMailBox(mensajeRecibido.idOrigen);
                                        puertos.lstMailBox[idx].lstMensajes.Add(mensajeRecibido);
                                    }
                                        
                                }
                                else
                                {
                                    StreamWriter WriteReportFile2 = File.AppendText("Prueba.txt");
                                    string historia = "Mensaje no encontrado";
                                    WriteReportFile2.WriteLine(historia);
                                    WriteReportFile2.Close();
                                    ltsLog.Add(new Log(idProceso.ToString(), "no hay mensajes por recibir"));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
