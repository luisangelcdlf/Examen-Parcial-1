namespace Examen_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cmbMonedaOrigen = new ComboBox();
            txtMonto = new TextBox();
            btnSeleccionar = new Button();
            grpConversiones = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Moneda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 28);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Monto";
            // 
            // cmbMonedaOrigen
            // 
            cmbMonedaOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonedaOrigen.Location = new Point(100, 63);
            cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            cmbMonedaOrigen.Size = new Size(191, 28);
            cmbMonedaOrigen.TabIndex = 3;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(400, 63);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(170, 27);
            txtMonto.TabIndex = 2;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = SystemColors.Highlight;
            btnSeleccionar.Location = new Point(400, 110);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(170, 35);
            btnSeleccionar.TabIndex = 1;
            btnSeleccionar.Text = "Calcular";
            btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // grpConversiones
            // 
            grpConversiones.Location = new Point(100, 180);
            grpConversiones.Name = "grpConversiones";
            grpConversiones.Size = new Size(450, 323);
            grpConversiones.TabIndex = 0;
            grpConversiones.TabStop = false;
            grpConversiones.Text = "Conversiones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 536);
            Controls.Add(grpConversiones);
            Controls.Add(btnSeleccionar);
            Controls.Add(txtMonto);
            Controls.Add(cmbMonedaOrigen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Convertidor de Monedas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbMonedaOrigen;
        private TextBox txtMonto;
        private Button btnSeleccionar;
        private GroupBox grpConversiones;
    }
}
