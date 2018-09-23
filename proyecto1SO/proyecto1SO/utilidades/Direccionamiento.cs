using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Direccionamiento
    {
        public Directo directo;
        public Indirecto indirecto;
        public byte tipo;
        public bool Directo;


        public Direccionamiento()
        {
            Directo = false;
            directo = new Directo();
            indirecto = new Indirecto();
            tipo = 0;
        }
    }
}
