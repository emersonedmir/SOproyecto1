using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class config
    {
        public Sincronizacion sincronizacion;
        public Direccionamiento direccionamiento;
        public Formato formato;
        public DisciplinaColas colas;

        public config()
        {
            sincronizacion = new Sincronizacion();
            direccionamiento = new Direccionamiento();
            formato = new Formato();
            colas = new DisciplinaColas();
        }

        
    }
}
