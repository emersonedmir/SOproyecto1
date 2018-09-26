using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto1SO.utilidades;

namespace proyecto1SO
{
    public partial class MainForm : Form
    {
        public Config configuracion;        
        private List<Thread> hilos;
        //private List<controlBlock> lstControlBlock;
        public List<Log> log;
        private List<Operacion> operaciones;
        private static Mutex mutexOper = new Mutex();


        public MainForm()
        {
            hilos = new List<Thread>();
            log = new List<Log>();
            operaciones = new List<Operacion>();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            configuracion = new Config();
            btConfig_Click(btConfig, new EventArgs());
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            bool actualizado = modificar_config(configuracion);
            if (actualizado)
            {
                inicializar_Sistema();
                preparar_Sistema();
                iniciar_Hilos();
            }
        }

        private void inicializar_Sistema() // Regresa el sistema al estado inicial
        {
            listPids.Items.Clear();
            for (int i = 0; i < (hilos.Count); i++)
            {
                hilos[i].Abort();                
            }
            procesos.lstProcesos.Clear();
            procesos.MailBox.Clear();
            hilos.Clear();
            operaciones.Clear();
            
            Grid.Rows.Clear();
            Grid.Visible = false;            
            listPids.Visible = false;
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
                        Grid.Rows[i].Cells[1].Value = configuracion.confProceso.puertosEmisor[i];
                        Grid.Rows[i].Cells[2].Value = configuracion.confProceso.puertosReceptor[i];
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
        }
        private Thread crear_Hilo(int i)
        {
           
            mailBox buzon;
            buzon = new mailBox();
            hilo newProceso;
            newProceso = new hilo(i, configuracion);
            procesos.lstProcesos.Add(newProceso);
            procesos.MailBox.Add(buzon);

 
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
            mutexOper.WaitOne();
            //operaciones

            //creamos el mensaje y cargamos los datos
            Mensaje msg = new Mensaje();
            msg.idDestino = int.Parse(tbRece.Text);
            msg.idOrigen = int.Parse(tbEmis.Text);
            msg.Contenido = tbMens.Text;
            if (rbSend.Checked)
            {
                msg.TipoMsg = tipoMensaje.send;
            }
            else
            {
                msg.TipoMsg = tipoMensaje.receive;
            }
            if (configuracion.formato.largo.fijo)
            {
                msg.Tamanio = configuracion.formato.largo.tamMax;
            }
            else
            {
                msg.Tamanio = float.Parse(tbTamanio.Text);
            }
            if(msg.TipoMsg == tipoMensaje.send)
            {
                procesos.lstProcesos[msg.idOrigen].lstMensajes.Add(msg);
            }
            else
            {
                procesos.lstProcesos[msg.idDestino].lstMensajes.Add(msg);
            }
            
            


            mutexOper.ReleaseMutex();
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
    }
}
