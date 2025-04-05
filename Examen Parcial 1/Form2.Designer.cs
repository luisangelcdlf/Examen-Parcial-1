namespace Examen_1
{
    partial class Form2
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
            checkedListBox1 = new CheckedListBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(50, 40);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(349, 290);
            checkedListBox1.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.Highlight;
            btnAceptar.Location = new Point(139, 365);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(169, 35);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            ClientSize = new Size(461, 484);
            Controls.Add(btnAceptar);
            Controls.Add(checkedListBox1);
            Name = "Form2";
            Text = "Seleccionar Monedas";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button btnAceptar;
    }
}
