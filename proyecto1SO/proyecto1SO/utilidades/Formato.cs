using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Formato
    {
        private bool Contenido;
        public Largo largo;

        public Formato()
        {
            Contenido = false;
            largo = new Largo();
        }

        public bool contenido
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
