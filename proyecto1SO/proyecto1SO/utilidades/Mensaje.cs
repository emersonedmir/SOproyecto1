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
        public Mensaje()
        {
            Tamanio = 0;            
            TipoMen = "";
            Contenido = "";
        }

        public Mensaje(float pTamanio, string pTipoMen, string pContenido)
        {
            Tamanio = pTamanio;            
            TipoMen = pTipoMen;
            Contenido = pContenido;
        }
    }
}
