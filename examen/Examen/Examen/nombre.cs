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
    public partial class nombre : Form
    {
        public nombre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarNumeros();
        }
        private void MostrarNumeros()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) // múltiplo de 3 y 5
                {
                    listBox1.Items.Add("Junior Garcia");
                }
                else if (i % 3 == 0) // múltiplo de 3
                {
                    listBox1.Items.Add("Junior");
                }
                else if (i % 5 == 0) // múltiplo de 5
                {
                    listBox1.Items.Add("Garcia");
                }
                else // no es múltiplo de 3 ni de 5
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }
    }
}
