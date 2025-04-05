using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Form2 : Form
    {
        public List<string> MonedasSeleccionadas = new List<string>();

        public Form2()
        {
            InitializeComponent();

            checkedListBox1.Items.Add("USD");
            checkedListBox1.Items.Add("MXN");
            checkedListBox1.Items.Add("CAD");
            checkedListBox1.Items.Add("EUR");
            checkedListBox1.Items.Add("JPY");

            btnAceptar.Click += btnAceptar_Click;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MonedasSeleccionadas.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                MonedasSeleccionadas.Add(item.ToString());
            }

            if (MonedasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Selecciona al menos una moneda");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
