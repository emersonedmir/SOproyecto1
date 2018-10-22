using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Log
    {
        const string sep = "; ";
        public string logStr;

        public String idProceso;
        public DateTime fecha;
        public Mensaje mensaje;

        public Log(string pIdProceso, string pDesEvento)
        {
            idProceso = pIdProceso;
            mensaje = null;
            fecha = DateTime.Now;
            logStr = fecha.ToShortDateString() +" "+ fecha.ToLongTimeString() + sep + "Proceso: " + idProceso;
            logStr += sep + "evento: " + pDesEvento;
        }

        public Log(string pIdProceso, Mensaje pMen)
        {
            idProceso = pIdProceso;
            mensaje = pMen;
            fecha = DateTime.Now;            
            logStr = fecha.ToShortDateString() + " " + fecha.ToLongTimeString() + sep + "Proceso: " + idProceso;
            if (mensaje.TipoMsg == tipoMensaje.receive)
                logStr += sep + "evento: " + tipoMensaje.receive.ToString() + sep + "origen: " + mensaje.idOrigen;
            else
                logStr += sep + "evento: " + tipoMensaje.send.ToString() + sep + "destino: " + mensaje.idDestino;
            logStr += sep + "Mensaje["+mensaje.Tamanio.ToString()+"]: " + "\""+ mensaje.Contenido + "\"";
        }
        public override string ToString()
        {
            return logStr + '\n';
        }
    }
}
