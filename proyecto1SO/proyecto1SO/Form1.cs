using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto1SO.utilidades;

namespace proyecto1SO
{
    public partial class Form1 : Form
    {
        public Config configuracion;
        public List<Log> log;
        

        public Form1()
        {
            log = new List<Log>();            
            InitializeComponent();            
        }
        private bool modificar_config(Config pConfig)
        {
            FParamConfig fConfig = new FParamConfig(pConfig);
            fConfig.ShowDialog();
            bool actualizado = fConfig.actualizado;
            if (actualizado)
                configuracion = fConfig.config;
            fConfig = null;
            return actualizado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configuracion = new Config();
            modificar_config(configuracion);
            //configuraccion.sincronizacion.send.blocking = true;
            //configuraccion.sincronizacion.send.nonblocking = true;
            //configuraccion.sincronizacion.receive.blocking = true;
            //configuraccion.sincronizacion.receive.nonblocking = true;
            //configuraccion.sincronizacion.receive.pruebaLlegada = true;

            //configuraccion.direccionamiento.directo.Send = true;
            //configuraccion.direccionamiento.directo.receive.explicito = true;
            //configuraccion.direccionamiento.directo.receive.implicito = true;
            //configuraccion.direccionamiento.indirecto.estatico = true;
            //configuraccion.direccionamiento.indirecto.dinamico = true;

            //configuraccion.formato.contenido = true;
            //configuraccion.formato.largo.fijo = true;
            //configuraccion.formato.largo.variable = true;

            //configuraccion.colas.FIFO = true;
            //configuraccion.colas.Prioridad = true;


        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            modificar_config(configuracion);
        }
    }
}
