using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Log
    {
        public String idProceso;
        public DateTime fecha;
        public String descripcionEvento;

        public Log()
        {
            idProceso = string.Empty;
            descripcionEvento = string.Empty;
        }
    }
}
