using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

           Form pasar = new interes();
           pasar.MdiParent = this;
           pasar.Show();
            
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pasar = new descuento();
            pasar.MdiParent = this;
            pasar.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pasar = new nombre();
            pasar.MdiParent = this;
            pasar.Show();
        }
    }
}
