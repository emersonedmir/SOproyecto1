using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Directo
    {
        public bool Send;
        public Receive receive;        

        public Directo()
        {
            Send = false;
            receive = new Receive();
        }

    }
}
