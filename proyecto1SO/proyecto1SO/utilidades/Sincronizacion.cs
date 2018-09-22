using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Sincronizacion
    {
        public Send send;
        public Receive receive;

        public Sincronizacion()
        {
            send = new Send();
            receive = new Receive();
        }        
    }
}
