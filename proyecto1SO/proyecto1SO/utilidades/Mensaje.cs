using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public enum tipoMensaje
    {
        send,
        receive,
    }
    public class Mensaje
    {
        public float Tamanio;
        public tipoMensaje TipoMsg;
        public string Contenido;
        //public int idDestino;
        //public int idOrigen;
        public string strDestino;
        public string strOrigen;
        public int prioridad;
        //public Mensaje()
        //{
        //    Tamanio = 0;
        //    TipoMsg = tipoMensaje.send;
        //    Contenido = "";
        //    idDestino = 0;
        //    idOrigen = 0;
        //    prioridad = 0;
        //}

        //public Mensaje(float pTamanio, tipoMensaje pTipoMen, string pContenido, int origen, int destino)
        //{
        //    Tamanio = pTamanio;
        //    TipoMsg = pTipoMen;
        //    Contenido = pContenido;
        //    idOrigen = origen;
        //    idDestino = destino;
        //}
        public Mensaje()
        {
            Tamanio = 0;
            TipoMsg = tipoMensaje.send;
            Contenido = "";
            strDestino = "";
            strOrigen = "";
            prioridad = 0;
        }

        public Mensaje(float pTamanio, tipoMensaje pTipoMen, string pContenido, string origen, string destino)
        {
            Tamanio = pTamanio;
            TipoMsg = pTipoMen;
            Contenido = pContenido;
            strOrigen = origen;
            strDestino = destino;
        }
        public override string ToString()
        {
            return "Tipo: " + TipoMsg.ToString() + "; Origen: " + strOrigen +"; Destino: " + strDestino + "; Contenido[" + Tamanio.ToString() + "]" + Contenido;
        }
    }
}