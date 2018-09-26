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
        public void documentar(Mensaje msg)
        {
            string direccionamiento= string.Empty;
            string tipoDireccionamiento = string.Empty;
            string colaPrioridad = string.Empty;
            string bloqueo = string.Empty;

            if (configuracion.direccionamiento.tipo==0){direccionamiento = "directo ";}else{direccionamiento = "indirecto ";}
            if(msg.TipoMsg== tipoMensaje.send){tipoDireccionamiento = "send ";}else{tipoDireccionamiento = "receive ";}
            if (configuracion.colas.FIFO) { colaPrioridad = "FIFO "; }else { colaPrioridad = "Prioridad "; }
            if (configuracion.sincronizacion.send.blocking || configuracion.sincronizacion.receive.blocking)
            { bloqueo = " blocking"; }
            else if(configuracion.sincronizacion.send.nonblocking || configuracion.sincronizacion.receive.nonblocking)
            { bloqueo = " no bloking"; }
          
            StreamWriter WriteReportFile = File.AppendText("Prueba.txt");
            string historia = "direccionamiento: " + direccionamiento + ", Tipo mensaje: " + tipoDireccionamiento + "Tipo cola: " + colaPrioridad +", Origen:"+ msg.idOrigen + " destino " + msg.idDestino + " contenido: " + msg.Contenido + ", procesado";
            WriteReportFile.WriteLine(historia);
            WriteReportFile.Close();
            lstMensajes.Remove(msg);
            log.Add(historia);
        }

        public void verificarBuzon()
        {
            mutexOper.WaitOne();
            if (procesos.MailBox[idProceso].lstMensajes.Count > 0)
            {
                procesos.MailBox[idProceso].lstMensajes.Clear();
            }
            mutexOper.ReleaseMutex();
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
                                        documentar(lstMensajes[0]);
                                        desbloquear();
                                        mutexOper.ReleaseMutex();
                                    }
                                    else
                                    {//no blocking
                                        mutexOper.WaitOne();
                                        procesos.lstProcesos[lstMensajes[0].idDestino].lstMensajesRecibidos.Add(lstMensajes[0]);
                                        documentar(lstMensajes[0]);
                                        mutexOper.ReleaseMutex();
                                    }
                                }
                                else
                                {//direccionamiento directo, disciplina fifo, receive


                                    

                                    if (configuracion.sincronizacion.receive.blocking)
                                    {
                                        mutexOper.WaitOne();
                                        Mensaje msg = lstMensajes[0];
                                        
                                        bool encontrar = false;
                                        bloquear();
                                        foreach(var item in lstMensajes)
                                        {
                                            if(item.TipoMsg== tipoMensaje.send && item.idOrigen == msg.idOrigen)
                                            {
                                                lstMensajesRecibidos.Add(msg);
                                                
                                                encontrar = true;
                                               
                                            }
                                           
                                        }
                                        lstMensajes.Remove(msg);
                                        mutexOper.ReleaseMutex();
                                        if (encontrar)
                                        {
                                            documentar(msg);
                                        }
                                       
                                        else
                                        {
                                            mutexOper.WaitOne();
                                            StreamWriter WriteReportFile1 = File.AppendText("Prueba.txt");
                                            string historia3 = "Mensaje no encontrado";
                                            WriteReportFile1.WriteLine(historia3);
                                            WriteReportFile1.Close();
                                            mutexOper.ReleaseMutex();
                                        }

                                        desbloquear();

                                    }
                                    else if(configuracion.sincronizacion.receive.nonblocking)
                                    {
                                        mutexOper.WaitOne();
                                        Mensaje msg = lstMensajes[0];
                                        bool encontrar = false;
                                       
                                        foreach (var item in lstMensajes)
                                        {
                                            if (item.TipoMsg == tipoMensaje.send && item.idOrigen == msg.idOrigen)
                                            {
                                                lstMensajesRecibidos.Add(msg);
                                                
                                                encontrar = true;
                                               
                                            }

                                        }
                                        lstMensajes.Remove(msg);
                                        mutexOper.ReleaseMutex();
                                        if (encontrar)
                                        {
                                            documentar(msg);
                                        }
                                        else
                                        {
                                            StreamWriter WriteReportFile2 = File.AppendText("Prueba.txt");
                                            string historia = "Mensaje no encontrado";
                                            WriteReportFile2.WriteLine(historia);
                                            WriteReportFile2.Close();
                                        }

                                        
                                    }
                                    else
                                    {//prueba de llegada
                                        

                                       
                                        Mensaje msg = lstMensajes[0];
                                       
                                        //bloquear();
                                        bool esperar = true;
                                        while(esperar) //esperando a recivir el mensaje
                                        { 
                                            foreach (var item in lstMensajes)
                                            {  
                                                if (item.TipoMsg == tipoMensaje.send && item.idOrigen == msg.idOrigen)
                                                {
                                                    
                                                    lstMensajesRecibidos.Add(msg);
                                                    esperar = false;
                                                    StreamWriter WriteReportFile1 = File.AppendText("Prueba.txt");
                                                    string historia3 = "aqui2";
                                                    WriteReportFile1.WriteLine(historia3);
                                                    WriteReportFile1.Close();
                                                   
                                                }
                                            }
                                            
                                        }
                                        lstMensajes.Remove(msg);
                                        //desbloquear();
                                        documentar(msg);
                                        
                                    }
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
                                            documentar(lstMensajes[0]);
                                            desbloquear();
                                            mutexOper.ReleaseMutex();
                                        }
                                        else
                                        {
                                            mutexOper.WaitOne();
                                            procesos.lstProcesos[msg.idDestino].lstMensajesRecibidos.Add(msg);
                                            documentar(lstMensajes[0]);
                                            mutexOper.ReleaseMutex();
                                        }
                                    }
                                    else
                                    {//direccionamiento directo, receive por prioridad
                                        if (configuracion.sincronizacion.receive.blocking)
                                        {
                                            msg = obtenerPrioridad();
                                            bool encontrar = false;
                                            bloquear();
                                            mutexOper.WaitOne();
                                            foreach (var item in lstMensajes)
                                            {
                                                if (item.TipoMsg == tipoMensaje.send && item.idOrigen == msg.idOrigen)
                                                {
                                                    lstMensajesRecibidos.Add(msg);
                                                    
                                                    encontrar = true;
                                                   
                                                }

                                            }
                                            lstMensajes.Remove(msg);
                                            mutexOper.ReleaseMutex();
                                            if (encontrar)
                                            {
                                                documentar(msg);
                                            }

                                            else
                                            {
                                                mutexOper.WaitOne();
                                                StreamWriter WriteReportFile1 = File.AppendText("Prueba.txt");
                                                string historia3 = "Mensaje no encontrado";
                                                WriteReportFile1.WriteLine(historia3);
                                                WriteReportFile1.Close();
                                                mutexOper.ReleaseMutex();
                                            }

                                            desbloquear();
                                        }
                                        else if (configuracion.sincronizacion.receive.nonblocking)
                                        {
                                            msg = obtenerPrioridad();
                                            bool encontrar = false;
                                            mutexOper.WaitOne();
                                            foreach (var item in lstMensajes)
                                            {
                                                if (item.TipoMsg == tipoMensaje.send && item.idOrigen == msg.idOrigen)
                                                {
                                                    lstMensajesRecibidos.Add(msg);
                                                   
                                                    encontrar = true;
                                                   
                                                }

                                            }
                                            lstMensajes.Remove(msg);
                                            mutexOper.ReleaseMutex();
                                            if (encontrar)
                                            {
                                                documentar(msg);
                                            }
                                            else
                                            {
                                                mutexOper.WaitOne();
                                                StreamWriter WriteReportFile2 = File.AppendText("Prueba.txt");
                                                string historia = "Mensaje no encontrado";
                                                WriteReportFile2.WriteLine(historia);
                                                WriteReportFile2.Close();
                                                mutexOper.ReleaseMutex();
                                            }
                                        }
                                        else
                                        {//prueba de llegada

                                            mutexOper.WaitOne();
                                            msg = lstMensajes[0];
                                            mutexOper.ReleaseMutex();
                                            bloquear();
                                            bool esperar = true;
                                            while (esperar) //esperando a recivir el mensaje
                                            {
                                                mutexOper.WaitOne();
                                                foreach (var item in lstMensajes)
                                                {
                                                    if (item.TipoMsg == tipoMensaje.send && item.idOrigen == msg.idOrigen)
                                                    {
                                                        lstMensajesRecibidos.Add(msg);
                                                        
                                                        esperar = false;
                                                    }
                                                }
                                                lstMensajes.Remove(msg);
                                                mutexOper.ReleaseMutex();
                                            }
                                            desbloquear();
                                            documentar(msg);
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
                    else
                    {//direccionamiento indirecto
                        verificarBuzon();

                        if (configuracion.colas.FIFO && lstMensajes.Count>0)
                        {//direccionamiento indirecto, disciplina fifo                             
                            Mensaje msg = lstMensajes[0];
                            if (msg.TipoMsg == tipoMensaje.send)
                                {//direccionamiento indirecto, disciplina fifo, tipo send
                                    if (configuracion.sincronizacion.send.blocking)
                                    {//direcionamiento indirecto, disciplina fifo, blocking
                                        bloquear();
                                        lstMensajes.Remove(msg);
                                        mutexOper.WaitOne();
                                        procesos.MailBox[msg.idDestino].lstMensajes.Add(msg);
                                        mutexOper.ReleaseMutex();
                                        bool esperar = true;
                                        while(esperar)
                                        {
                                            mutexOper.WaitOne();
                                            if (procesos.MailBox[msg.idDestino].lstMensajes.Count == 0) { esperar = false; }
                                            mutexOper.ReleaseMutex();
                                        }
                                        desbloquear();
                                        documentar(msg);                                         
                                    }
                                    else
                                    {
                                        mutexOper.WaitOne();
                                        documentar(msg);
                                        mutexOper.ReleaseMutex();
                                    }
                                }
                                else
                                {//direccionamiento indirecto, disciplina fifo, tipo receive

                                }
                            }
                        
                        else
                        {//direccionamiento indirecto, disciplina prioridad
                            
                            if (lstMensajes.Count>0)
                            {
                                
                                Mensaje msg = obtenerPrioridad();
                                
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
                                        documentar(msg);
                                        }
                                        else
                                        {//no blocking
                                            mutexOper.WaitOne();
                                            procesos.MailBox[msg.idDestino].lstMensajes.Add(msg);//se envia al buzon
                                            mutexOper.ReleaseMutex();
                                        documentar(msg);
                                    }
                                    }
                                    else
                                    {//direccionamiento indirecto, tipo prioridad, receive
                                        if (configuracion.sincronizacion.send.blocking)
                                        {//blocking
                                            bloquear();

                                            desbloquear();
                                        }
                                        else
                                        {//no blocking

                                        }
                                    }
                                }
                               

                                
                            }
                           
                        }
                    }
                }

            }
        }
    }

