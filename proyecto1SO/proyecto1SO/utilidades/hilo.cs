﻿using System;
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
            log = new List<string>();
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
            mutexOper.ReleaseMutex();
            return msg;
        }
        private int Get_IdxMailBox(int pPuerto)
        {
            int i;
            for (i = 0; i < puertos.lstMailBox.Count; i++)
                if (puertos.lstMailBox[i].puerto == pPuerto)
                    return i;
            return -1;
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
        private Mensaje Get_mensaje()
        {
            Mensaje mensaje = null;
            if ((configuracion.direccionamiento.tipo == 0) || (configuracion.direccionamiento.indirecto.dinamico))
            {
                mutexGetMen.WaitOne();
                //Los procesos se seleccionan siempre en FIFO -> mensaje:{send|receive}
                mensaje = lstMensajes[0];
                lstMensajes.Remove(mensaje);
                mutexGetMen.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Pendiente seleccionar el mensaje-> si es recibe debende del puerto del proceso.");
            }
            return mensaje;
        }
        public void ejecutar(object pParametros)
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.estado == estadoProceso.noBloqueado)
                {
                    if (lstMensajes.Count > 0)
                    {
                        Mensaje mensaje = Get_mensaje();
                        if (configuracion.direccionamiento.tipo == 0) // tipo: 0=directo, 1=indirecto
                        {//direccionamiento directo                            


                            if (mensaje.TipoMsg == tipoMensaje.send)
                            {//direccionamiento directo, disciplina fifo, send
                                if (configuracion.sincronizacion.send.blocking)
                                {// blocking
                                    bloquear();
                                    mutexOper.WaitOne();
                                    procesos.lstProcesos[mensaje.idDestino].lstMensajesRecibidos.Add(mensaje);
                                    documentar(mensaje);
                                    //desbloquear(); no desbloquear hasta obtener respuesta
                                    mutexOper.ReleaseMutex();
                                }
                                else
                                {//no blocking
                                    mutexOper.WaitOne();
                                    procesos.lstProcesos[mensaje.idDestino].lstMensajesRecibidos.Add(mensaje);
                                    documentar(mensaje);
                                    mutexOper.ReleaseMutex();
                                }
                            }
                            else // Receive
                            {
                                bool encontrado = false;
                                Mensaje mensajeRecibido = null;
                                if (configuracion.sincronizacion.receive.blocking)
                                {
                                    bloquear();
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
                                }
                                else if (configuracion.sincronizacion.receive.nonblocking)
                                {
                                    mensajeRecibido = obtenerMenRecibido(mensaje.idOrigen);  //Origen=-1 -> recibe implisito
                                    encontrado = (mensajeRecibido != null);
                                }
                                else
                                {//prueba de llegada                                       
                                    bloquearBW();
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
                                }
                                if (encontrado)
                                {
                                    documentar(mensajeRecibido);
                                    if (configuracion.sincronizacion.send.blocking)
                                        procesos.lstProcesos[mensajeRecibido.idOrigen].desbloquear();
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
                                if (configuracion.sincronizacion.send.blocking)
                                {// blocking
                                    bloquear();
                                    mutexOper.WaitOne();
                                    int idx = Get_IdxMailBox(mensaje.idDestino);
                                    puertos.lstMailBox[idx].lstMensajes.Add(mensaje);
                                    mutexOper.ReleaseMutex();
                                    documentar(mensaje);
                                    bool respuesta = false;
                                    while (!respuesta)
                                    {
                                        mutexOper.WaitOne();
                                        idx = Get_IdxMailBox(mensaje.idOrigen);
                                        if (puertos.lstMailBox[idx].lstMensajes.IndexOf(mensaje) >= 0)
                                        {
                                            respuesta = true;
                                            puertos.lstMailBox[idx].lstMensajes.Remove(mensaje);
                                            desbloquear();
                                        }
                                        mutexOper.ReleaseMutex();
                                    }
                                }
                                else if (configuracion.sincronizacion.send.nonblocking)
                                {//no blocking
                                    mutexOper.WaitOne();
                                    int idx = Get_IdxMailBox(mensaje.idDestino);
                                    puertos.lstMailBox[idx].lstMensajes.Add(mensaje);
                                    mutexOper.ReleaseMutex();
                                    documentar(mensaje);
                                }
                                else
                                {
                                    bloquearBW();
                                    mutexOper.WaitOne();
                                    int idx = Get_IdxMailBox(mensaje.idDestino);
                                    puertos.lstMailBox[idx].lstMensajes.Add(mensaje);
                                    mutexOper.ReleaseMutex();
                                    documentar(mensaje);
                                    bool respuesta = false;
                                    while (!respuesta)
                                    {
                                        mutexOper.WaitOne();
                                        idx = Get_IdxMailBox(mensaje.idOrigen);
                                        if (puertos.lstMailBox[idx].lstMensajes.IndexOf(mensaje) >= 0)
                                        {
                                            respuesta = true;
                                            puertos.lstMailBox[idx].lstMensajes.Remove(mensaje);
                                            desbloquear();
                                        }
                                        mutexOper.ReleaseMutex();
                                    }
                                }
                            }
                            else // Receive
                            {
                                if (mensaje != null)
                                {
                                    MessageBox.Show("Receive direccionamiento indirecto");
                                }
                            }
                            //verificarBuzon();

                            //if (configuracion.colas.FIFO && lstMensajes.Count>0)
                            //{//direccionamiento indirecto, disciplina fifo                             
                            //    Mensaje msg = lstMensajes[0];
                            //    if (msg.TipoMsg == tipoMensaje.send)
                            //        {//direccionamiento indirecto, disciplina fifo, tipo send
                            //            if (configuracion.sincronizacion.send.blocking)
                            //            {//direcionamiento indirecto, disciplina fifo, blocking
                            //                bloquear();
                            //                lstMensajes.Remove(msg);
                            //                mutexOper.WaitOne();
                            //                procesos.MailBox[msg.idDestino].lstMensajes.Add(msg);
                            //                mutexOper.ReleaseMutex();
                            //                bool esperar = true;
                            //                while(esperar)
                            //                {
                            //                    mutexOper.WaitOne();
                            //                    if (procesos.MailBox[msg.idDestino].lstMensajes.Count == 0) { esperar = false; }
                            //                    mutexOper.ReleaseMutex();
                            //                }
                            //                desbloquear();
                            //                documentar(msg);                                         
                            //            }
                            //            else
                            //            {
                            //                mutexOper.WaitOne();
                            //                documentar(msg);
                            //                mutexOper.ReleaseMutex();
                            //            }
                            //        }
                            //        else
                            //        {//direccionamiento indirecto, disciplina fifo, tipo receive

                            //        }
                            //    }

                            //else
                            //{//direccionamiento indirecto, disciplina prioridad

                            //    if (lstMensajes.Count>0)
                            //    {

                            //        Mensaje msg = obtenerPrioridad();

                            //            if (msg.TipoMsg == tipoMensaje.send)
                            //            {//direccionamiento indirecto, tipo prioridad, send
                            //                if (configuracion.sincronizacion.send.blocking)
                            //                {//blocking
                            //                    bloquear();
                            //                    mutexOper.WaitOne();
                            //                    procesos.MailBox[msg.idDestino].lstMensajes.Add(msg);//se envia al buzon
                            //                    mutexOper.ReleaseMutex();
                            //                    bool esperar = true;
                            //                    while (esperar)
                            //                    {
                            //                        mutexOper.WaitOne();
                            //                        if (procesos.MailBox[msg.idDestino].lstMensajes.Count == 0)
                            //                            esperar = false;
                            //                        mutexOper.ReleaseMutex();
                            //                    }
                            //                    desbloquear();
                            //                documentar(msg);
                            //                }
                            //                else
                            //                {//no blocking
                            //                    mutexOper.WaitOne();
                            //                    procesos.MailBox[msg.idDestino].lstMensajes.Add(msg);//se envia al buzon
                            //                    mutexOper.ReleaseMutex();
                            //                documentar(msg);
                            //            }
                            //            }
                            //            else
                            //            {//direccionamiento indirecto, tipo prioridad, receive
                            //                if (configuracion.sincronizacion.send.blocking)
                            //                {//blocking
                            //                    bloquear();

                            //                    desbloquear();
                            //                }
                            //                else
                            //                {//no blocking

                            //                }
                            //            }
                            //        }



                            //    }

                            //}
                        }
                    }
                }
            }
        }
    }
}
