﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    public class Config
    {
        public Sincronizacion sincronizacion;
        public Direccionamiento direccionamiento;
        public Formato formato;       
        public DisciplinaColas colas;        
        public ConfProceso confProceso;

        public Config()
        {
            sincronizacion = new Sincronizacion();
            direccionamiento = new Direccionamiento();
            formato = new Formato();
            confProceso = new ConfProceso();
            colas = new DisciplinaColas();
        }

        
    }
}
