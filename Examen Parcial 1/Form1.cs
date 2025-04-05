using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> simbolos = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, double>> tasas = new Dictionary<string, Dictionary<string, double>>();

        public Form1()
        {
            InitializeComponent();
            simbolos.Add("MXN", "$");
            simbolos.Add("USD", "$");
            simbolos.Add("CAD", "C$");
            simbolos.Add("EUR", "€");
            simbolos.Add("JPY", "¥");

            tasas.Add("USD", new Dictionary<string, double>());
            tasas["USD"].Add("MXN", 19.38);
            tasas["USD"].Add("CAD", 1.38);
            tasas["USD"].Add("EUR", 0.92);
            tasas["USD"].Add("JPY", 149.77);

            tasas.Add("MXN", new Dictionary<string, double>());
            tasas["MXN"].Add("USD", 0.05);
            tasas["MXN"].Add("CAD", 0.07);
            tasas["MXN"].Add("EUR", 0.05);
            tasas["MXN"].Add("JPY", 7.73);

            tasas.Add("CAD", new Dictionary<string, double>());
            tasas["CAD"].Add("USD", 0.72);
            tasas["CAD"].Add("MXN", 14.05);
            tasas["CAD"].Add("EUR", 0.66);
            tasas["CAD"].Add("JPY", 108.56);

            tasas.Add("EUR", new Dictionary<string, double>());
            tasas["EUR"].Add("USD", 1.09);
            tasas["EUR"].Add("MXN", 21.13);
            tasas["EUR"].Add("CAD", 1.50);
            tasas["EUR"].Add("JPY", 163.31);

            tasas.Add("JPY", new Dictionary<string, double>());
            tasas["JPY"].Add("USD", 0.0067);
            tasas["JPY"].Add("MXN", 0.1293);
            tasas["JPY"].Add("CAD", 0.0092);
            tasas["JPY"].Add("EUR", 0.0061);

            cmbMonedaOrigen.Items.Add("MXN");
            cmbMonedaOrigen.Items.Add("USD");
            cmbMonedaOrigen.Items.Add("CAD");
            cmbMonedaOrigen.Items.Add("EUR");
            cmbMonedaOrigen.Items.Add("JPY");
            cmbMonedaOrigen.SelectedIndex = 0;

            btnSeleccionar.Click += btnSeleccionar_Click;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            grpConversiones.Controls.Clear();
            double monto = 0;
            bool esNumero = double.TryParse(txtMonto.Text, out monto);

            if (!esNumero)
            {
                MessageBox.Show("Ingresa un numero que sea valido");
                return;
            }

            string origen = cmbMonedaOrigen.SelectedItem.ToString();
            Form2 ventana = new Form2();
            var resultado = ventana.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                int posY = 20;
                foreach (string destino in ventana.MonedasSeleccionadas)
                {
                    if (destino != origen)
                    {
                        if (tasas.ContainsKey(origen) && tasas[origen].ContainsKey(destino))
                        {
                            double tasa = tasas[origen][destino];
                            double total = monto * tasa;
                            string simbolo = simbolos[destino];

                            Label lbl = new Label();
                            lbl.Text = destino + ":";
                            lbl.Location = new Point(10, posY);

                            TextBox txt = new TextBox();
                            txt.Text = simbolo + " " + total.ToString("0.00");
                            txt.Location = new Point(80, posY);
                            txt.Width = 100;

                            grpConversiones.Controls.Add(lbl);
                            grpConversiones.Controls.Add(txt);
                            posY += 30;
                        }
                    }
                }
            }
        }
    }
}
