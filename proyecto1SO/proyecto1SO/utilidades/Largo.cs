using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Largo
    {
        private bool Fijo;
        private bool Variable;

        public Largo()
        {
            Fijo = true;
            Variable = false;
        }

        public bool fijo
        {
            get
            {
                return Fijo;
            }
            set
            {
                Fijo = value;
                if (value)
                    Variable = false;
            }
        }

        public bool variable
        {
            get
            {
                return Variable;
            }
            set
            {
                Variable = value;
                if (value)
                    Fijo = false;
            }
        }
    }
}
