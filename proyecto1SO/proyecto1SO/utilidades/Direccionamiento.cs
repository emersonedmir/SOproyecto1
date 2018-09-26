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
        public byte tipo; // 0: directo; 1:indirecto


        public Direccionamiento()
        {
            directo = new Directo();
            indirecto = new Indirecto();
            tipo = 0;
        }
    }
}
