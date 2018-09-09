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
            Explicito = false;
            Implicito = false;
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
                if (value)
                {
                    Nonblocking = false;
                    PruebaLlegada = false;
                    Explicito = false;
                    Implicito = false;
                }
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
                if (value)
                {
                    Blocking = false;                    
                    PruebaLlegada = false;
                    Explicito = false;
                    Implicito = false;
                }
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
                if (value)
                {
                    Blocking = false;
                    Nonblocking = false;                    
                    Explicito = false;
                    Implicito = false;
                }
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
                if (value)
                {
                    Blocking = false;
                    Nonblocking = false;
                    PruebaLlegada = false;                    
                    Implicito = false;
                }
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
                if (value)
                {
                    Blocking = false;
                    Nonblocking = false;
                    PruebaLlegada = false;
                    Explicito = false;                    
                }
            }
        }

    }
}
