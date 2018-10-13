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
    public partial class FBatch : Form
    {
        public bool actualizado = false;
        public Config config;

        public FBatch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizado = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbNombreArchivo.Text = "archivo: " + openFileDialog1.SafeFileName;

                List<string> elementos = new List<string>();
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    elementos.Add(line);
                }
                if (elementos[0] == "0")
                {
                    config.sincronizacion.send.blocking = true; 
                    config.sincronizacion.send.nonblocking = false; 
                }
                else
                {
                    config.sincronizacion.send.blocking = true;
                    config.sincronizacion.send.nonblocking = false;
                }

                //sincronizacion receive
                if(elementos[1]=="0")
                {
                    config.sincronizacion.receive.blocking = true; 
                    config.sincronizacion.receive.nonblocking = false; 
                    config.sincronizacion.receive.pruebaLlegada = false;
                }
                else if(elementos[1]=="1")
                {
                    config.sincronizacion.receive.blocking = false;
                    config.sincronizacion.receive.nonblocking = true;
                    config.sincronizacion.receive.pruebaLlegada = false;
                }
                else
                {
                    config.sincronizacion.receive.blocking = false;
                    config.sincronizacion.receive.nonblocking = false;
                    config.sincronizacion.receive.pruebaLlegada = true;
                }

                //direccionamiento tipo
                if(elementos[2]=="0")
                {
                    config.direccionamiento.tipo = 0;
                    config.direccionamiento.directo.Send = true;
                    if(elementos[3]=="0")
                    {
                        config.direccionamiento.directo.receive.explicito = true;
                        config.direccionamiento.directo.receive.implicito = false;
                    }
                    else
                    {
                        config.direccionamiento.directo.receive.explicito = false;
                        config.direccionamiento.directo.receive.implicito = true;
                    }
                }
            }
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            FGenerarTxt frm = new FGenerarTxt();
            frm.ShowDialog();
        }
    }
}
