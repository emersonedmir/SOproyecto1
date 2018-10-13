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
using System.IO;

namespace proyecto1SO
{
   
    public partial class FGenerarTxt : Form
    {
        Config configuracion;
        public FGenerarTxt()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            rbD1.Text = "explicito";
            rbD2.Text = "implicito";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            rbD1.Text = "estatico";
            rbD2.Text = "dinámico";
        }

        private void FGenerarTxt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar Archivo de Texto";
            saveFileDialog1.Filter = "Archivo de Texto (.txt) |*.txt";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = false;
            saveFileDialog1.RestoreDirectory = true;


            configuracion = new Config();
            StreamWriter WriteReportFile;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WriteReportFile = File.AppendText(saveFileDialog1.FileName);
                //sincronizacion
                if (rbSSB.Checked)
                {
                    //configuracion.sincronizacion.send.blocking = true;
                    WriteReportFile.WriteLine("0");
                    
                }
                else
                {
                    //configuracion.sincronizacion.send.blocking = true;
                    WriteReportFile.WriteLine("1");
                   
                }
                if (rbSRB.Checked)
                {
                    //configuracion.sincronizacion.receive.blocking = true;
                    WriteReportFile.WriteLine("0");
                    
                }
                else if (rbSRNB.Checked)
                {
                    
                    //configuracion.sincronizacion.receive.noblocking = true;
                    WriteReportFile.WriteLine("1");
                    
                }
                else
                {
                    //configuracion.sincronizacion.receive.pruebaDeLlegada = true;
                    WriteReportFile.WriteLine("2");
                }

                //direccionamiento
                if (rbDD.Checked)
                {
                    //direccionamiento.tipo
                    WriteReportFile.WriteLine("0");

                    if (rbD1.Checked)
                    {
                        //direcionamiento.directo.receive.explicito
                        WriteReportFile.WriteLine("0");
                       
                    }
                    else
                    {
                        //direcionamiento.directo.receive.implicito
                        WriteReportFile.WriteLine("1");
                    }
                }
                else
                {
                    //direccionamiento.tipo
                    WriteReportFile.WriteLine("1");
                    if (rbD1.Checked)
                    {
                        //direcionamiento.indirecto.estatico
                        WriteReportFile.WriteLine("0");
                        
                    }
                    else
                    {
                        //direcionamiento.indirecto.dinamico
                        WriteReportFile.WriteLine("1");
                    }
                }

                //formato
                if (rbFCT.Checked)
                {
                    //formato.contenido.texto
                    WriteReportFile.WriteLine("0");
                   
                }
                else if (rbFCA.Checked)
                {
                    
                    WriteReportFile.WriteLine("1");
                    
                }
                else
                {
                    //formato.contenido.multimedia
                    WriteReportFile.WriteLine("2");
                }
                //tamanho cola de mensajes
                WriteReportFile.WriteLine(npFNmax.Value.ToString());

                //disciplina de manejo de colass
                if (rbDisFIFO.Checked)
                {
                    //fifo
                    WriteReportFile.WriteLine("0");
                }
                else
                {
                    //prioridad
                    WriteReportFile.WriteLine("1");
                }
                //tamanho cola de mensaje
                WriteReportFile.WriteLine(npTamColaMen.Value.ToString());

                //cantidad de proceso
                WriteReportFile.Write(npProcesos.Value.ToString());
                WriteReportFile.Close();
                WriteReportFile.Dispose();

            }




        }

        private void rbSSB_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
