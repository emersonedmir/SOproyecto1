using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Receive
    {
        private bool Blocking;
        private bool Nonblocking;
        private bool PruebaLlegada;
        private bool Explicito;
        private bool Implicito; 


        public Receive()
        {
            Blocking = false;
            Nonblocking = false;
            PruebaLlegada = false;
        }

        public bool blocking
        {
            get
            {
                return Blocking;
            }
            set
            {
                Blocking = value;
            }
        }

        public bool nonblocking
        {
            get
            {
                return Nonblocking;
            }
            set
            {
                Nonblocking = value;
            }
        }

        public bool pruebaLlegada
        {
            get
            {
                return PruebaLlegada;
            }
            set
            {
                PruebaLlegada = value;
            }
        }

        public bool explicito
        {
            get
            {
                return Explicito;
            }
            set
            {
                Explicito = value;
            }
        }

        public bool implicito
        {
            get
            {
                return Implicito;
            }
            set
            {
                Implicito = value;
            }
        }

    }
}
