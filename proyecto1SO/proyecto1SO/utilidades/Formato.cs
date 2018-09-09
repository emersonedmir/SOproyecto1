using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Formato
    {
        private string Contenido;
        public Largo largo;

        public Formato()
        {
            Contenido = "";
            largo = new Largo();
        }

        public string contenido
        {
            get
            {
                return Contenido;
            }
            set
            {
                Contenido = value;
            }
        }
    }
}
