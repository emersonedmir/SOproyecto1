using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class DisciplinaColas
    {
        public bool FIFO;
        public bool Prioridad;
        public int TamColasMen;

        public DisciplinaColas()
        {
            FIFO = true;
            Prioridad = true;
            TamColasMen = 10;
        }
    }
}
