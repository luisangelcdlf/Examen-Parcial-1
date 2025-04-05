using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Form2 : Form
    {
        public List<string> MonedasSeleccionadas { get; private set; }

        public Form2()
        {
            InitializeComponent();
            MonedasSeleccionadas = new List<string>();

            checkedListBox1.Items.AddRange(new string[] { "USD", "MXN", "CAD", "EUR", "JPY" });
            btnAceptar.Click += btnAceptar_Click;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MonedasSeleccionadas.Clear();

            foreach (object item in checkedListBox1.CheckedItems)
            {
                MonedasSeleccionadas.Add(item.ToString());
            }

            if (MonedasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Selecciona al menos una moneda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
