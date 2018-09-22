using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    class Mensaje
    {
        public float Tamanio;
        public string TipoMen;
        public string Contenido;
        public int idDestino;
        public int idOrigen;
        public int prioridad;
        public Mensaje()
        {
            Tamanio = 0;            
            TipoMen = "";
            Contenido = "";
            idDestino = 0;
            idOrigen = 0;
            prioridad = 0;
        }

        public Mensaje(float pTamanio, string pTipoMen, string pContenido)
        {
            Tamanio = pTamanio;            
            TipoMen = pTipoMen;
            Contenido = pContenido;
        }
    }
}
