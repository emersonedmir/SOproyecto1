using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class ConfProceso
    {
        public int numProcesos;
        public List<int> puertosReceptor;
        public List<int> puertosEmisor;

        public ConfProceso()
        {
            numProcesos = 1;
            puertosReceptor = new List<int>();
            puertosEmisor = new List<int>();
        }
    }
}
