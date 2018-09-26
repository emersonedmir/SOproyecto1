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
                //lstControlBlock.Add(crear_controlBlock(i));                
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
                    listPids.Items.Add(hilos[i].ManagedThreadId.ToString());
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
            if (configuracion.modo == Modo.Interactivo)
            {
                pninteractivo.Visible = true;
                Size = new Size(778, 536);                
            }
            else
            {
                pninteractivo.Visible = false;
                //Cargar send y receibe desde archivo batch.txt
                Size = new Size(778, 215);
            }

        }
        private Thread crear_Hilo(int i)
        {
            //Thread newThread = new Thread(new ParameterizedThreadStart(funcion_Hilo));
            //newThread.Name = String.Format("Thread{0}", i + 1);
            //return newThread;
            mailBox buzon;
            buzon = new mailBox();
            hilo newProceso;
            newProceso = new hilo(i, configuracion);
            procesos.lstProcesos.Add(newProceso);
            procesos.MailBox.Add(buzon);

            //Thread newThread = new Thread(new ThreadStart(newProceso.ejecutar));
            Thread newThread = new Thread(new ParameterizedThreadStart(newProceso.ejecutar));
            newThread.Name = String.Format("Thread{0}", i);
            //newThread.Start();
            return newThread;
        }

        //private controlBlock crear_controlBlock(int i)
        //{
        //    controlBlock newControlBlock = new controlBlock();
        //    newControlBlock.puerto = i + 1;
        //    return newControlBlock;

        //}
        private void iniciar_Hilos()
        {
            for (int i = 0; i < (hilos.Count); i++)
            {
                string[] parametros = { i.ToString(), hilos[i].ManagedThreadId.ToString(), hilos[i].Name };
                hilos[i].Start(parametros);
            }
        }

        //private void funcion_Hilo(object pParametros)  //solicitar y ejecutar instruccion
        //{
        //    string[] parametros = (string[])pParametros;
        //    int idx_hilo = Convert.ToInt32(parametros[0]);
        //    int t_id = Convert.ToInt32(parametros[1]);
        //    string t_name = parametros[2];
        //    MessageBox.Show(
        //        "Index array: " + idx_hilo.ToString() + '\n' +
        //        "ThreadId: " + t_name + '\n' +
        //        "ThreadName: " + t_id.ToString() + '\n' +
        //        "Hilo en curso");
        //    Operacion operacionActual;
        //    while (true)
        //    {                
        //        operacionActual = null;
        //        mutexOper.WaitOne();
        //        if (operaciones.Count > 0)
        //        {                    
        //            foreach (Operacion ope in operaciones)
        //            {
        //                if (ope.comando == Comando.Send)
        //                {
        //                    if (configuracion.direccionamiento.tipo == 0)       // DIRECTO
        //                    {
        //                        if (ope.mensaje.idOrigen == t_id)
        //                        {
        //                            operacionActual = ope;
        //                            operaciones.Remove(ope);
        //                            break;
        //                        }
        //                    }
        //                }
        //                else if (ope.comando == Comando.Receive)
        //                {
        //                    if (configuracion.direccionamiento.tipo == 0)       // DIRECTO
        //                    {
        //                        if (ope.mensaje.idOrigen == t_id)
        //                        {
        //                            operacionActual = ope;
        //                            operaciones.Remove(operacionActual);
        //                            break;
        //                        }
        //                    }
        //                }
        //            }                    
        //        }                    
        //        mutexOper.ReleaseMutex();
        //        if (operacionActual != null)
        //        {
        //            //realizar accion 
        //            switch (operacionActual.comando)
        //            {
        //                case Comando.Send:
        //                    //verificar si hay que bloquearlo
        //                    if(configuracion.sincronizacion.send.blocking)
        //                    {
        //                        //verificar si es un send directo
        //                        if(configuracion.direccionamiento.directo.Send)
        //                        {

        //                        }
        //                        else
        //                        {
        //                            //es un send indirecto
        //                        }

        //                    }
        //                    //No se debe bloquear
        //                    else
        //                    {

        //                    }
        //                    break;
        //                case Comando.Receive:
        //                    //Rrealizar Receive
        //                    break;
        //            }
        //        }
        //    }

        //}

        //private Operacion Crear_Operacion() {
        //    float tamanio = float.Parse(tbTamanio.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
        //    Mensaje mensaje = new Mensaje(tamanio, configuracion.formato.contenido, tbMens.Text, );
        //    mensaje.idOrigen = int.Parse(tbEmis.Text);
        //    mensaje.idDestino = int.Parse(tbRece.Text);
        //    mensaje.prioridad = 0;
        //    Comando comando = Comando.None;
        //    if (rbSend.Checked)
        //        comando = Comando.Send;
        //    if (rbReceive.Checked)
        //        comando = Comando.Receive;
        //    Operacion operacion = new Operacion(comando, tbEmis.Text, tbRece.Text, mensaje);
        //    return operacion;
        //}
        //private void add_Operacion()
        //{
        //    Operacion operacion = Crear_Operacion();
        //    if (configuracion.colas.FIFO)
        //        operaciones.Add(operacion);
        //    else
        //    {
        //        int i = 0;
        //        while (i < operaciones.Count - 1) {
        //            if (operaciones[i].prioridad < (int)nuPrio.Value)
        //                break;
        //            else
        //                i++;
        //        }
        //        operaciones.Insert(i, operacion);
        //    }
        //}


        //private void btProcesar_Click(object sender, EventArgs e)
        //{
        //    mutexOper.WaitOne();
        //    add_Operacion();
        //    mutexOper.ReleaseMutex();
        //}

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
            if (configuracion.direccionamiento.tipo == 0) // tipo: 0=directo, 1=indirecto
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

        private void tbRece_Validating(object sender, CancelEventArgs e)
        {
            if ((configuracion.direccionamiento.tipo == 0) || ((configuracion.direccionamiento.tipo == 1) && (configuracion.direccionamiento.indirecto.dinamico)))
            {
                if (listPids.Items.IndexOf(((TextBox)sender).Text) == -1)
                {
                    ((TextBox)sender).Text = "";
                }
            }

        }

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
