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
    public partial class interes : Form
    {
        private decimal capital = 200000.00m;
        private decimal tasaInteres = 0.015m; // 1.5%
        private int tiempo = 12; // 12 meses
        private List<string> valores;
        public interes()
        {
            InitializeComponent();
            InicializarValores();
            ActualizarListBox();
        }

        private void InicializarValores()
        {
            valores = new List<string>();
            for (int i = 1; i <= tiempo; i++)
            {
                decimal interes = CalcularInteres(capital, tasaInteres, i);
                valores.Add($"{ObtenerNombreMes(i)} - L {interes.ToString("0.00")}");
            }
        }
        private void ActualizarListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = valores;
        }
        private decimal CalcularInteres(decimal capital, decimal tasaInteres, int tiempo)
        {
            return capital * tasaInteres * tiempo;
        }
        private string ObtenerNombreMes(int mes)
        {
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                default: return "";
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            InicializarValores();
            ActualizarListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
