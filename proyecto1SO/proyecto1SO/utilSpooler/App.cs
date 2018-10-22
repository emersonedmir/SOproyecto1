using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilSpooler
{
    class App
    {
        public string nombre;
        public int prioridad;
        public App(string pNombre, int pPrioridad)
        {
            this.nombre = pNombre;
            this.prioridad = pPrioridad;
        }
    }
}
