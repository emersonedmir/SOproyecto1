using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Indirecto
    {
        private bool Estatico;
        private bool Dinamico;
        private bool Propiedad;

        public Indirecto()
        {
            Estatico = false;
            Dinamico = false;
        }

        public bool propiedad
        {
            get
            {
                return Propiedad;
            }
            set
            {
                Propiedad = value;
            }
        }

        public bool estatico
        {
            get
            {
                return Estatico;
            }
            set
            {
                Estatico = value;
            }
        }

        public bool dinamico
        {
            get
            {
                return Dinamico;
            }
            set
            {
                Dinamico = value;
            }
        }

    }
}
