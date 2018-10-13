using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto1SO.utilidades;

namespace proyecto1SO
{
    public enum Modo
    {
        Interactivo,
        Batch,
        Ninguno
    }
    public partial class MainForm : Form
    {
        private string[] estados = new string[] { "bloqueado", "no bloqueado", "busy waiting" };

        private Modo modo = Modo.Ninguno;
        public Config configuracion;        
        private List<Thread> hilos;
        //private List<controlBlock> lstControlBlock;
        public List<Log> log;
        //private List<Operacion> operaciones;
        private static Mutex mutexOper = new Mutex();


        public MainForm()
        {
            hilos = new List<Thread>();
            log = new List<Log>();
            //operaciones = new List<Operacion>();
            //lstControlBlock = new List<controlBlock>();
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

        private bool modificar_configBatch(Config pConfig)
        {
            FBatch fConfig = new FBatch();
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
        }
        private void rbInter_Click(object sender, EventArgs e)
        {
            if (modo != Modo.Interactivo)
            {
                modo = Modo.Interactivo;
                btConfig_Click(btConfig, new EventArgs());                
            }
                
        }
        private void rbBatch_Click(object sender, EventArgs e)
        {
            if (modo != Modo.Batch)
            {
                modo = Modo.Batch;
                //ejecutar Create de config del modo batch
                reiniciar();
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            bool actualizado = modificar_config(configuracion);
            if (actualizado)
                reiniciar();
        }

        private void reiniciar() {
            inicializar_Sistema();
            preparar_Sistema();
            iniciar_Hilos();
        }

        private void inicializar_Sistema() // Regresa el sistema al estado inicial
        {
            listPids.Items.Clear();
            for (int i = 0; i < (hilos.Count); i++)
            {
                hilos[i].Abort();
            }
            procesos.lstProcesos.Clear();
            puertos.lstMailBox.Clear();
            procesosDDin.lstProcesosDDin.Clear();
            hilos.Clear();
            //operaciones.Clear();

            Grid.Rows.Clear();
            Grid.Visible = false;
            listPids.Visible = false;
            bool modoInte = (modo == Modo.Interactivo);                                                
            pnBotones.Visible = true;
            pnProcesar.Visible = modoInte;
            pnBatchCmd.Visible = !modoInte;
        }
        private void mostrar_camposEmiRecep() {
            tbEmis.Text = "";
            tbRece.Text = "";
            pnMen.Visible = (rbSend.Checked);
            if (rbSend.Checked) {
                cnEmis.Visible = true;
            }
            else {
                tbMens.Text = "";
                cnEmis.Visible = true;                
                if (configuracion.direccionamiento.tipo == 0)
                    cnEmis.Visible = (configuracion.direccionamiento.directo.receive.explicito);
                else
                    cnEmis.Visible = (configuracion.direccionamiento.indirecto.dinamico);
            }
        }

        private void preparar_Sistema() // Aplica configuraciones visuales de los parametros
        {
            Grid.RowCount = configuracion.confProceso.numProcesos;
            for (int i = 0; i < configuracion.confProceso.numProcesos; i++)
            {
                hilos.Add(crear_Hilo(i));
                          
                if (configuracion.direccionamiento.tipo == 1) {
                    lbPids.Text = "Puertos";
                    if (configuracion.direccionamiento.indirecto.estatico) {                        
                        Grid.Visible = true;
                        Grid.Rows[i].Cells[0].Value = i;
                        Grid.Rows[i].Cells[1].Value = configuracion.confProceso.puertosReceptor[i];                        
                    }
                }
                else {
                    lbPids.Text = "Procesos";
                    listPids.Visible = true;
                    listPids.Items.Add(i);
                }                        
            }
            if ((configuracion.direccionamiento.tipo == 1) && (configuracion.direccionamiento.indirecto.dinamico))
            {
                listPids.Visible = true;                        
                for (int i = 0; i < configuracion.direccionamiento.indirecto.Puertos.Count(); i++)
                    listPids.Items.Add(configuracion.direccionamiento.indirecto.Puertos[i]);
            }
            if (configuracion.formato.largo.fijo)
                tbMens.MaxLength = configuracion.formato.largo.tamMax;
            else
                tbMens.MaxLength = 0;
            pnPrio.Visible = configuracion.colas.Prioridad;
            if (configuracion.direccionamiento.tipo == 1)
            {
                foreach (var id in configuracion.direccionamiento.indirecto.Puertos)
                {
                    MailBox puerto = new MailBox(id);
                    puertos.lstMailBox.Add(puerto);
                }
            }
                            
        }
        private Thread crear_Hilo(int i)
        {                      
            hilo newProceso;
            newProceso = new hilo(i, configuracion);
            procesos.lstProcesos.Add(newProceso);

 
            Thread newThread = new Thread(new ParameterizedThreadStart(newProceso.ejecutar));
            newThread.Name = String.Format("Thread{0}", i);
       
            return newThread;
        }

       
        private void iniciar_Hilos()
        {
            for (int i = 0; i < (hilos.Count); i++)
            {
                string[] parametros = { i.ToString(), hilos[i].ManagedThreadId.ToString(), hilos[i].Name };
                hilos[i].Start(parametros);
            }
        }

        

        private void btProcesar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            //operaciones
            //creamos el mensaje y cargamos los datos
            Mensaje msg = new Mensaje();
            if (pnPrio.Visible)
                msg.prioridad = (int)nuPrio.Value;
            if (cnRece.Visible)
            {
                if (tbRece.Text.Trim() != "")
                    msg.idDestino = int.Parse(tbRece.Text);
                else
                    valido = false;
            }                
            else
                msg.idDestino = -1;
            if (cnEmis.Visible)
            {
                if (tbEmis.Text.Trim() != "")
                    msg.idOrigen = int.Parse(tbEmis.Text);
                else
                    valido = false;
            }                
            else
                msg.idOrigen = -1;            
            if (rbSend.Checked)
            {
                msg.TipoMsg = tipoMensaje.send;
            }
            else
            {
                msg.TipoMsg = tipoMensaje.receive;
            }
            if (rbSend.Checked) {
                msg.Contenido = tbMens.Text;
                if (configuracion.formato.largo.fijo)
                {
                    msg.Tamanio = configuracion.formato.largo.tamMax;
                    if (tbTamanio.Text.Trim() == "")
                        tbTamanio.Text = "0";
                    msg.Contenido.PadRight((int)msg.Tamanio - int.Parse(tbTamanio.Text), 'X');
                }
                else
                    msg.Tamanio = float.Parse(tbTamanio.Text);
            }
            if (valido)
            {                
                mutexOper.WaitOne();
                if (configuracion.direccionamiento.tipo == 0)
                {
                    // Los mensajes [Send|receive] se mandan a al buffer del proceso
                    // Send: este se encarga de enviarlo a un buffer de entrada del otro proceso
                    //receive: procesa y notifica su cola de entrada.
                    if (msg.TipoMsg == tipoMensaje.send)
                        procesos.lstProcesos[msg.idOrigen].lstMensajes.Add(msg);
                    else
                        procesos.lstProcesos[msg.idDestino].lstMensajes.Add(msg);
                }
                else
                {
                    // Los mensajes [Send|receive] se mandan a al buffer global.
                    // Send: este se encarga de mover del buffer global al puerto de entrada del receive
                    // receive: procesa y notifica su cola de entrada de su puerto.
                    procesosDDin.lstProcesosDDin.Add(msg);
                }                
                mutexOper.ReleaseMutex();
                MessageBox.Show("Operación enviada.");
            }            
        }

        private void tbMens_TextChanged(object sender, EventArgs e)
        {
            tbTamanio.Text = tbMens.TextLength.ToString();
        }

        //private void tbRece_Validating(object sender, CancelEventArgs e)
        //{
           // if ((configuracion.direccionamiento.tipo == 0) || ((configuracion.direccionamiento.tipo == 1) && (configuracion.direccionamiento.indirecto.dinamico)))
           // {
              //  if (listPids.Items.IndexOf(((TextBox)sender).Text) == -1)
              //  {
               //     ((TextBox)sender).Text = "";
               // }
           // }

        //}

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicializar_Sistema();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string archivoLog = "log.txt";
            foreach (var item in procesos.lstProcesos)
            {
                item.estadoBloqueo();
            }

            string contenido = "";
            string estados = "Procesos: ";
            foreach (var item in procesos.lstProcesos)
            {
                estados += "\tProceso " + item.idProceso.ToString() + item.estado.ToString() + '\n';
                contenido += item.ToString();
                contenido += '\n';
            }
            contenido += "Estado actual:\n" + estados;
            System.IO.File.Delete(@archivoLog);
            StreamWriter WriteReportFile = File.AppendText(archivoLog);
            WriteReportFile.Flush();
            WriteReportFile.Write(contenido);
            WriteReportFile.Close();
            MessageBox.Show("archivo log.txt generado");
        }

        private void rbSend_Click(object sender, EventArgs e)
        {
            mostrar_camposEmiRecep();
        }

        private void tbEmis_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmis.Text.Trim() == tbRece.Text.Trim())
                ((TextBox)sender).Text = "";
        }

        private void rbBatch_CheckedChanged(object sender, EventArgs e)
        {
            bool actualizado = modificar_configBatch(configuracion);
            if (actualizado)
                reiniciar();
        }

        private void rbInter_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
