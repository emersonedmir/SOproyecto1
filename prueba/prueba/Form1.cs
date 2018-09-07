using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int n = 0;
        public Example hilos; 
        public Form1()
        {
            hilos = new Example();
            hilos.Main();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            n = hilos.nElemntos();
            hilos.listar(1);
            listBox1.Items.Add(n.ToString());

        }
    }
}
