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
        private List<controlBlock> lstControlBlock;
        public List<Log> log;
        private List<Operacion> operaciones;
        private static Mutex mutexOper = new Mutex();


        public Form1()
        {
            hilos = new List<Thread>();
            log = new List<Log>();
            operaciones = new List<Operacion>();
            lstControlBlock = new List<controlBlock>();
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
            for (int i = 0; i < (hilos.Count - 1); i++)
                hilos[i].Abort();
            hilos.Clear();
            operaciones.Clear();
        }

        private void preparar_Sistema() // Aplica configuraciones visuales de los parametros
        {
            for (int i = 0; i < configuracion.numHilos; i++)
            {
                hilos.Add(crear_Hilo(i));
                lstControlBlock.Add(crear_controlBlock(i));
                listPids.Items.Add(hilos[i].ManagedThreadId.ToString());
            }
            if (configuracion.formato.largo.fijo)
                tbMens.MaxLength = configuracion.formato.largo.tamMax;
            else
                tbMens.MaxLength = 0;
            pnPrio.Visible = configuracion.colas.Prioridad;
        }
        private Thread crear_Hilo(int i)
        {
            Thread newThread = new Thread(new ThreadStart(funcion_Hilo));
            newThread.Name = String.Format("Thread{0}", i + 1);
            return newThread;
        }

        private controlBlock crear_controlBlock(int i)
        {
            controlBlock newControlBlock = new controlBlock();
            newControlBlock.puerto = i + 1;
            return newControlBlock;

        }
        private void iniciar_Hilos()
        {
            for (int i = 0; i < (hilos.Count - 1); i++)
                hilos[i].Start();
        }

        private void funcion_Hilo()  //solicitar y ejecutar instruccion
        {
            Operacion operacionActual;
            while (true)
            {
                operacionActual = null;
                mutexOper.WaitOne();
                if (operaciones.Count > 0)
                {
                    operacionActual = operaciones[0];
                    operaciones.Remove(operacionActual);
                }                    
                mutexOper.ReleaseMutex();
                if (operacionActual != null)
                {
                    //realizar accion 
                    switch (operacionActual.comando)
                    {
                        case Comando.Send:
                            //verificar si hay que bloquearlo
                            if(configuracion.sincronizacion.send.blocking)
                            {
                                //verificar si es un send directo
                                if(configuracion.direccionamiento.directo.Send)
                                {

                                }
                                else
                                {
                                    //es un send indirecto
                                }

                            }
                            //No se debe bloquear
                            else
                            {

                            }
                            break;
                        case Comando.Receive:
                            //Rrealizar Receive
                            break;
                    }
                }
            }
            
        }

        private Operacion Crear_Operacion() {
            float tamanio = float.Parse(tbTamanio.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            Mensaje mensaje = new Mensaje(tamanio, configuracion.formato.contenido, tbMens.Text);
            Comando comando = Comando.None;
            if (rbSend.Checked)
                comando = Comando.Send;
            if (rbReceive.Checked)
                comando = Comando.Receive;
            Operacion operacion = new Operacion(comando, tbEmis.Text, tbRece.Text, mensaje);
            return operacion;
        }
        private void add_Operacion()
        {
            Operacion operacion = Crear_Operacion();
            if (configuracion.colas.FIFO)
                operaciones.Add(operacion);
            else
            {
                int i = 0;
                while (i < operaciones.Count - 1) {
                    if (operaciones[i].prioridad < (int)nuPrio.Value)
                        break;
                    else
                        i++;
                }
                operaciones.Insert(i, operacion);
            }
        }


        private void btProcesar_Click(object sender, EventArgs e)
        {
            mutexOper.WaitOne();
            add_Operacion();
            mutexOper.ReleaseMutex();
        }

        private void tbMens_TextChanged(object sender, EventArgs e)
        {
            tbTamanio.Text = tbMens.TextLength.ToString();
        }

        private void tbRece_Validating(object sender, CancelEventArgs e)
        {            
            if (listPids.Items.IndexOf(((TextBox)sender).Text) == -1)
            {
                ((TextBox)sender).Text = "";
            }
        }
    }
}
