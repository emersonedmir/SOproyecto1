using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Send
    {
        private bool Blocking;
        private bool Nonblocking;

        public Send()
        {
            Blocking = true;
            Nonblocking = false;
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
                { Nonblocking = false; }
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
                { Blocking = false; }
            }
        }    
    }
}
