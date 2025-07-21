namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevaInternacion = new Button();
            btnObraSocial = new Button();
            btnInternados = new Button();
            SuspendLayout();
            // 
            // btnNuevaInternacion
            // 
            btnNuevaInternacion.Location = new Point(56, 35);
            btnNuevaInternacion.Name = "btnNuevaInternacion";
            btnNuevaInternacion.Size = new Size(200, 44);
            btnNuevaInternacion.TabIndex = 0;
            btnNuevaInternacion.Text = "Nueva Internación";
            btnNuevaInternacion.UseVisualStyleBackColor = true;
            btnNuevaInternacion.Click += btnNuevaInternacion_Click;
            // 
            // btnObraSocial
            // 
            btnObraSocial.Location = new Point(56, 96);
            btnObraSocial.Name = "btnObraSocial";
            btnObraSocial.Size = new Size(200, 44);
            btnObraSocial.TabIndex = 1;
            btnObraSocial.Text = "Obra Social";
            btnObraSocial.UseVisualStyleBackColor = true;
            btnObraSocial.Click += btnObraSocial_Click;
            // 
            // btnInternados
            // 
            btnInternados.Location = new Point(56, 159);
            btnInternados.Name = "btnInternados";
            btnInternados.Size = new Size(200, 44);
            btnInternados.TabIndex = 2;
            btnInternados.Text = "Ver Internados";
            btnInternados.UseVisualStyleBackColor = true;
            btnInternados.Click += btnInternados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 244);
            Controls.Add(btnInternados);
            Controls.Add(btnObraSocial);
            Controls.Add(btnNuevaInternacion);
            Name = "Form1";
            Text = "Hospital";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevaInternacion;
        private Button btnObraSocial;
        private Button btnInternados;
    }
}
