using proyecto1SO.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1SO
{
    public partial class FParamConfig : Form
    {
        private string[] EtiparamDir = { "Receive", "Indirecto" };
        private string[] itemsCbD = { "Explícito", "Implícito" };
        private string[] itemsCbI = { "Estático", "Dinámico" };
        public bool actualizado = false;
        public Config config;
        public FParamConfig()
        {
            InitializeComponent();
            despl_config(new Config());
        }
        public FParamConfig(Config pConfig)
        {
            InitializeComponent();
            despl_config(pConfig);
        }
        private void despl_config(Config pConfig)
            {
                config = pConfig;
            /* sincronizacion */
            if (config.sincronizacion.send.blocking)
                cbSincS.SelectedIndex = 0;
            else
                cbSincS.SelectedIndex = 1;
            if (config.sincronizacion.receive.blocking)
                cbSincR.SelectedIndex = 0;
            else if (config.sincronizacion.receive.nonblocking)
                cbSincR.SelectedIndex = 1;
            else
                cbSincR.SelectedIndex = 2;

            /* direccionamiento */
            if (config.direccionamiento.tipo == 0)
            {
                rbDirDi_Click(rbDirDi, new EventArgs());
                if (config.direccionamiento.directo.receive.explicito)
                    cbDirec.SelectedIndex = 0;
                else
                    cbDirec.SelectedIndex = 1;
            }
            else
            {
                rbDirIn_Click(rbDirIn, new EventArgs());
                if (config.direccionamiento.indirecto.estatico)
                    cbDirec.SelectedIndex = 0;
                else
                    cbDirec.SelectedIndex = 1;
            }

            /* formato */
            cbFomtC.SelectedIndex = cbFomtC.Items.IndexOf(config.formato.contenido);
            if (cbFomtC.SelectedIndex == -1)
                cbFomtC.SelectedIndex = 0;
            if (config.formato.largo.fijo){
                cbFomtL.SelectedIndex = 0;
                pnTamFijo.Visible = true;
                nuTamMax.Value = config.formato.largo.tamMax;
            }             
            else{
                cbFomtL.SelectedIndex = 1;
                pnTamFijo.Visible = false;
                nuTamMax.Value = 0;
            }               

            /* colas */
            if (config.colas.FIFO)
                cbColas.SelectedIndex = 0;
            else
                cbColas.SelectedIndex = 1;
            nuTamColaMen.Value = config.colas.TamColasMen;

            /*Procesos*/            
            nuHilos.Value = config.confProceso.numProcesos;
            nuHilos_ValueChanged(nuHilos, new EventArgs());
            if (habilitarGridPuertos()) {                
                for (int i = 0; i < config.confProceso.puertosEmisor.Count; i++)
                {
                    Grid.Rows[i].Cells[1].Value = config.confProceso.puertosEmisor[i];
                    Grid.Rows[i].Cells[2].Value = config.confProceso.puertosReceptor[i];
                }
            }            

        }
        private void rbDirDi_Click(object sender, EventArgs e)
        {            
            lbDire2.Text = EtiparamDir[0];
            cbDirec.Items.Clear();
            cbDirec.Items.AddRange(itemsCbD);
            cbDirec.SelectedIndex = 0;
            ((RadioButton)sender).Checked = true;
            habilitarGridPuertos();
        }

        private void rbDirIn_Click(object sender, EventArgs e)
        {
            lbDire2.Text = EtiparamDir[1];
            cbDirec.Items.Clear();
            cbDirec.Items.AddRange(itemsCbI);
            cbDirec.SelectedIndex = 0;
            ((RadioButton)sender).Checked = true;
            habilitarGridPuertos();
        }
        private void actualizar_config()
        {
            /* sincronizacion */
            switch (cbSincS.SelectedIndex){
                case 0: config.sincronizacion.send.blocking = true; break;
                case 1: config.sincronizacion.send.nonblocking = true; break;
            }
            switch (cbSincR.SelectedIndex) {
                case 0: config.sincronizacion.receive.blocking = true; break;
                case 1: config.sincronizacion.receive.nonblocking = true; break;
                case 2: config.sincronizacion.receive.pruebaLlegada = true; break;
            }

            /* direccionamiento */
            if (rbDirDi.Checked) {
                config.direccionamiento.tipo = 0;
                config.direccionamiento.directo.Send=true;
                switch (cbDirec.SelectedIndex){
                    case 0: config.direccionamiento.directo.receive.explicito = true; break;
                    case 1: config.direccionamiento.directo.receive.implicito = true; break;
                }
            }
            else{
                config.direccionamiento.tipo = 1;
                switch (cbDirec.SelectedIndex){
                    case 0: config.direccionamiento.indirecto.estatico = true; break;
                    case 1: config.direccionamiento.indirecto.dinamico = true; break;
                }
            }

            /* formato */
            if (cbFomtC.SelectedIndex >=0)
                config.formato.contenido = (string)cbFomtC.SelectedItem;
            else
                config.formato.contenido = "";
            switch (cbFomtL.SelectedIndex){
                case 0: config.formato.largo.fijo = true; break;
                case 1: config.formato.largo.variable = true; break;
            }
            config.formato.largo.tamMax = (int)nuTamMax.Value;

            /* colas */
            config.colas.FIFO = false;
            config.colas.Prioridad = false;
            switch (cbColas.SelectedIndex){
                case 0: config.colas.FIFO = true; break;
                case 1: config.colas.Prioridad = true; break;
            }
            config.colas.TamColasMen = (int)nuTamColaMen.Value;
            /* Procesos */
            config.confProceso.numProcesos = (int)nuHilos.Value;
            if (Grid.Visible)
            {
                config.confProceso.puertosEmisor.Clear();
                config.confProceso.puertosReceptor.Clear();
                for (int i = 0; i < config.confProceso.numProcesos; i++)
                {
                    config.confProceso.puertosEmisor.Add(Convert.ToInt32(Grid.Rows[i].Cells[1].FormattedValue));
                    config.confProceso.puertosReceptor.Add(Convert.ToInt32(Grid.Rows[i].Cells[2].FormattedValue));
                }
            }

        }
        private void btAplicar_Click(object sender, EventArgs e)
        {
            actualizado = true;
            actualizar_config();
            this.Close();
        }

        private void cbFomtL_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnTamFijo.Visible = (cbFomtL.SelectedIndex == 0);
        }
        private bool habilitarGridPuertos()
        {
            bool mostrar = ((rbDirIn.Checked) && (cbDirec.SelectedIndex == 0));
            Grid.Visible = mostrar;
            return mostrar;
        }

        private void nuHilos_ValueChanged(object sender, EventArgs e)
        {
            //if (Grid.Visible)
            //{
                Grid.RowCount = (int)nuHilos.Value;
                for (int i = 0; i < Grid.RowCount; i++)
                    Grid.Rows[i].Cells[0].Value = i + 1;
            //}
        }

        private void cbDirec_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarGridPuertos();
        }
    }
}
