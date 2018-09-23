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
    public partial class Form1 : Form
    {
        public Config configuracion;        
        private List<Thread> hilos;
        
       
        private List<Operacion> operaciones;
        private static Mutex mutexOper = new Mutex();
      

        public Form1()
        {
            hilos = new List<Thread>();
            
            operaciones = new List<Operacion>();
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
                
                preparar_Sistema();
                
            }
        }

        

        private void preparar_Sistema() // Aplica configuraciones visuales de los parametros
        {
            listPids.Items.Clear();
            for (int i = 0; i < configuracion.numHilos; i++)
            {
                crear_Hilo(i);
                listPids.Items.Add(i);
            }
            if (configuracion.formato.largo.fijo)
                tbMens.MaxLength = configuracion.formato.largo.tamMax;
            else
                tbMens.MaxLength = 0;
            pnPrio.Visible = configuracion.colas.Prioridad;
        }
        private void crear_Hilo(int i)
        {
            mailBox buzon;
            buzon = new mailBox();
            hilo newProceso;
            newProceso = new hilo(i, configuracion);
            procesos.lstProcesos.Add(newProceso);
            procesos.MailBox.Add(buzon);
            Thread newThread = new Thread(new ThreadStart(newProceso.ejecutar));
            newThread.Name = String.Format("Thread{0}", i);
            newThread.Start();
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
            if(rbSend.Checked)
            {
                msg.TipoMsg = tipoMensaje.send;
            }
            else
            {
                msg.TipoMsg = tipoMensaje.receive;
            }
            if(configuracion.formato.largo.fijo)
            {
                msg.Tamanio = configuracion.formato.largo.tamMax;
            }
            else
            {
                msg.Tamanio = float.Parse(tbTamanio.Text);
            }
            if(configuracion.direccionamiento.Directo)
            {
                procesos.lstProcesos[msg.idOrigen].lstMensajes.Add(msg);
            }
            else
            {
                procesos.MailBox[msg.idOrigen].lstMensajes.Add(msg);
            }

            
            mutexOper.ReleaseMutex();
        }

        private void tbMens_TextChanged(object sender, EventArgs e)
        {
            tbTamanio.Text = tbMens.TextLength.ToString();
        }

        
    }
}
