namespace Hospital
{
    partial class frmObraSocial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNoombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPorcentaje = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtNoombre
            // 
            txtNoombre.Location = new Point(21, 40);
            txtNoombre.Name = "txtNoombre";
            txtNoombre.Size = new Size(234, 23);
            txtNoombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Porcentaje";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(21, 84);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(234, 23);
            txtPorcentaje.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(180, 124);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmObraSocial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 171);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(txtPorcentaje);
            Controls.Add(label1);
            Controls.Add(txtNoombre);
            Name = "frmObraSocial";
            Text = "Obra Social";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNoombre;
        private Label label1;
        private Label label2;
        private TextBox txtPorcentaje;
        private Button btnAceptar;
    }
}