using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Moneda> Monedas { get; set; }
        public Dictionary<string, Dictionary<string, double>> Tasas { get; set; }

        public Form1()
        {
            InitializeComponent();
            InicializarMonedas();
            LlenarComboBox();
            btnSeleccionar.Click += btnSeleccionar_Click; // Conectar evento
        }


        private void InicializarMonedas()
        {
            Monedas = new Dictionary<string, Moneda>
            {
                {"MXN", new Moneda("MXN", "Peso mexicano", "$")},
                {"USD", new Moneda("USD", "Dólar estadounidense", "$")},
                {"CAD", new Moneda("CAD", "Dólar canadiense", "C$")},
                {"EUR", new Moneda("EUR", "Euro", "€")},
                {"JPY", new Moneda("JPY", "Yen japonés", "¥")}
            };

            Tasas = new Dictionary<string, Dictionary<string, double>>
            {
                {"USD", new Dictionary<string, double>{{"MXN", 19.38}, {"CAD", 1.38}, {"EUR", 0.92}, {"JPY", 149.77}}},
                {"MXN", new Dictionary<string, double>{{"USD", 0.05}, {"CAD", 0.07}, {"EUR", 0.05}, {"JPY", 7.73}}},
                {"CAD", new Dictionary<string, double>{{"USD", 0.72}, {"MXN", 14.05}, {"EUR", 0.66}, {"JPY", 108.56}}},
                {"EUR", new Dictionary<string, double>{{"USD", 1.09}, {"MXN", 21.13}, {"CAD", 1.50}, {"JPY", 163.31}}},
                {"JPY", new Dictionary<string, double>{{"USD", 0.0067}, {"MXN", 0.1293}, {"CAD", 0.0092}, {"EUR", 0.0061}}}
            };
        }

        private void LlenarComboBox()
        {
            cmbMonedaOrigen.Items.Clear();
            foreach (var moneda in Monedas.Values)
            {
                cmbMonedaOrigen.Items.Add(moneda.Codigo);
            }
            cmbMonedaOrigen.SelectedIndex = 0;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            grpConversiones.Controls.Clear();

            if (!double.TryParse(txtMonto.Text, out double monto))
            {
                MessageBox.Show("Ingresa un monto válido");
                return;
            }

            string origen = cmbMonedaOrigen.SelectedItem.ToString();

            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int y = 20;
                foreach (string destino in frm.MonedasSeleccionadas)
                {
                    if (destino == origen) continue;

                    if (Tasas[origen].TryGetValue(destino, out double tasa))
                    {
                        double resultado = monto * tasa;
                        string simbolo = Monedas[destino].Simbolo;

                        Label lbl = new Label
                        {
                            Text = $"{destino}:",
                            Location = new Point(10, y)
                        };

                        TextBox txt = new TextBox
                        {
                            Text = $"{simbolo} {resultado:0.00}",
                            Location = new Point(80, y),
                            Width = 100
                        };

                        grpConversiones.Controls.Add(lbl);
                        grpConversiones.Controls.Add(txt);
                        y += 30;
                    }
                }
            }
        }
    }
}

