using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class descuento : Form
    {
        public descuento()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de las cajas de texto
            string producto = textBoxproducto.Text;
            decimal precio = decimal.Parse(textBoxprecio.Text);
            int cantidad = int.Parse(textBoxcantidad.Text);

            // Calcular el subtotal y el descuento
            decimal subtotal = precio * cantidad;
            decimal descuento = await CalcularDescuentoAsync(subtotal);

            // Mostrar el descuento y el total a pagar al usuario

           // MessageBox.Show($"Descuento: {descuento:C}\nTotal a pagar: {subtotal - descuento:C}");

            // Mostrar el descuento en el label correspondiente
            labeldescuento.Text = descuento.ToString("C", new CultureInfo("es-ES")).Replace("€", "L");

            // Mostrar el total a pagar en el label correspondiente
            labeltotal.Text = (subtotal - descuento).ToString("C", new CultureInfo("es-ES")).Replace("€", "L");
        }
        private async Task<decimal> CalcularDescuentoAsync(decimal subtotal)
        {
            // Simular un cálculo asíncrono
            await Task.Delay(1000);

            // Calcular el descuento
            decimal descuento = subtotal * 0.15m;

            return descuento;
        }


    }
}
