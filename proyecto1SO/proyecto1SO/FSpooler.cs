using proyecto1SO.utilidades;
using proyecto1SO.utilSpooler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace proyecto1SO
{

    public partial class FSpooler : Form
    {
        public Config configuracion;
        private static Mutex mutexOper = new Mutex();
        public Modo modo = Modo.Ninguno;
        private List<App> apps;
        private List<Impresora> impresoras;
        public FSpooler()
        {
            InitializeComponent();

            apps = new List<App>();
            impresoras = new List<Impresora>();
            hilosSpooler.hilosApp = new List<Thread>();
            hilosSpooler.hilosMailBox = new List<Thread>();
            configuracion = new Config();           
        }
        private void iniciarSistema()
        {            
            tbPrio.Clear();
            configuracion.sincronizacion.send.nonblocking = true;
            configuracion.sincronizacion.receive.pruebaLlegada = true;
            configuracion.direccionamiento.tipo = 1;
            configuracion.direccionamiento.indirecto.dinamico = true;            
            configuracion.formato.contenido = "archivo";
            configuracion.formato.largo.variable = true;
            impresoras.Clear();
            apps.Clear();
            cbImps.Items.Clear();
            cbApps.Items.Clear();
            puertos.lstMailBox.Clear();
            procesos.lstProcesos.Clear();
            procesosDDin.lstProcesosDDin.Clear();
            abortarrHilos();
            mostrarImprimir();
            if (modo == Modo.Interactivo)
            {
                Add_App("Word",5);
                Add_App("Excel",4);
                Add_App("Mi_app",2);
                Add_Impresora("Canon", "Canon");
                Add_Impresora("HP", "HP");
            }
            else
            {
                // MODO BATCH
            }
        }
        private void abortarrHilos()
        {
            foreach (Thread item in hilosSpooler.hilosApp)
                item.Abort();            
            foreach (Thread item in hilosSpooler.hilosMailBox)
                item.Abort();
            hilosSpooler.hilosApp.Clear();
            hilosSpooler.hilosMailBox.Clear();
        }

        private bool Add_Impresora(String nombreImp, String nombreMB)
        {
            Impresora impresora = null;
            bool existe = false;
            foreach (Impresora imp in impresoras)
            {
                if (imp.nombre == nombreImp)
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
                impresora = new Impresora(nombreImp);
            if (impresora != null)
            {
                cbImps.Items.Add(nombreImp);
                impresoras.Add(impresora);
                puertos.lstMailBox.Add(new MailBox(nombreMB));
                hilosSpooler.hilosMailBox.Add(crear_HiloImp(nombreMB, impresoras.IndexOf(impresora)));
            }

            return (impresora != null);
        }
        private bool Add_App(String nombreApp, int pPrioridad)
        {
            App app = null;
            bool existe = false;
            foreach (App item in apps)
            {
                if (item.nombre == nombreApp)
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
                app = new App(nombreApp, pPrioridad);
            if (app != null)
            {
                cbApps.Items.Add(nombreApp);
                apps.Add(app);
                hilosSpooler.hilosApp.Add(crear_HiloApp(nombreApp, apps.IndexOf(app)));
            }                
            return (app != null);
        }
        private Thread crear_HiloApp(string nombre, int i)
        {
            hilo newProceso;
            newProceso = new hilo(i, configuracion);
            newProceso.nombre = nombre;
            procesos.lstProcesos.Add(newProceso);

            Thread newThread = new Thread(new ParameterizedThreadStart(newProceso.ejecutar));
            newThread.Name = nombre;
            string[] parametros = { i.ToString(), newThread.ManagedThreadId.ToString(), nombre };
            newThread.Start(parametros);

            return newThread;
        }
        private Thread crear_HiloImp(string nombre, int i)
        {
            Thread newThread = new Thread(new ParameterizedThreadStart(impresoras[i].Imprimir));
            newThread.Name = String.Format(nombre, i);
            string[] parametros = { i.ToString(), newThread.ManagedThreadId.ToString(), nombre };
            newThread.Start(parametros);
            return newThread;
        }

        private void rbInter_Click(object sender, EventArgs e)
        {
            if (((RadioButton)sender) == rbInter)
                modo = Modo.Interactivo;
            else            
                modo = Modo.Batch;             
            pnMain.Visible = true;
            bool mostrarMI = (modo == Modo.Interactivo);
            btAddApp.Visible = mostrarMI;
            btAddImp.Visible = mostrarMI;
            lbArch.Visible = mostrarMI;
            tbRutaArch.Visible = mostrarMI;
            tbRutaArch.Visible = mostrarMI;
            btBusArch.Visible = mostrarMI;
            gbEstImp.Enabled = mostrarMI;

            iniciarSistema();
        }

        private void btAddApp_Click(object sender, EventArgs e)
        {
            //
        }

        private void FSpooler_FormClosing(object sender, FormClosingEventArgs e)
        {
            abortarrHilos();
        }      

        private void tbRutaArch_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!System.IO.File.Exists(textBox.Text))
                textBox.Clear();
            mostrarImprimir();
        }

        private void btBusArch_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
                tbRutaArch.Text = openFile.FileName;                
            mostrarImprimir();
        }
        private void mostrarImprimir()
        {
            btImprimir.Visible = (modo == Modo.Interactivo) && (cbApps.SelectedIndex != -1) && (cbImps.SelectedIndex != -1) && (tbRutaArch.Text.Trim() != "");
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = new Mensaje();
            mensaje.prioridad  = int.Parse(tbPrio.Text.Trim());
            mensaje.strOrigen = cbApps.Text;
            mensaje.strDestino = cbImps.Text;
            mensaje.Tamanio = tbRutaArch.Text.Length;
            mensaje.Contenido = tbRutaArch.Text;
            mensaje.prioridad = int.Parse(tbPrio.Text);
            mensaje.TipoMsg = tipoMensaje.send;
            mutexOper.WaitOne();
            procesosDDin.lstProcesosDDin.Add(mensaje);
            mutexOper.ReleaseMutex();
            MessageBox.Show("Operación enviada.");
        }

        private void cbApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbApps.SelectedIndex > -1)
                tbPrio.Text = apps[cbApps.SelectedIndex].prioridad.ToString();
            else
                tbPrio.Clear();
            mostrarImprimir();
        }

        private void cbImps_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarImprimir();            
        }
        private void actulizar_campoEstado()
        {
            if (cbImps.SelectedIndex > -1)
            {
                if (impresoras[cbImps.SelectedIndex].estado == Impresora.EstadoImpresora.Activo)
                    rbEstA.Checked = true;
                else
                    rbEstS.Checked = true;

            }
        }

        private void rbEstA_Click(object sender, EventArgs e)
        {
            if (cbImps.SelectedIndex > -1)
            {
                if (((RadioButton)sender) == rbEstA)
                    impresoras[cbImps.SelectedIndex].estado = Impresora.EstadoImpresora.Activo;
                else
                    impresoras[cbImps.SelectedIndex].estado = Impresora.EstadoImpresora.Suspendido;
            }
        }

        private void pnMain_MouseMove(object sender, MouseEventArgs e)
        {
            actulizar_campoEstado();
        }
    }
}
