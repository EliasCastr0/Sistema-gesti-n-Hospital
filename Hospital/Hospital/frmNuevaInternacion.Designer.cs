namespace Hospital
{
    partial class frmNuevaInternacion
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
            label3 = new Label();
            txtDiaInternacion = new TextBox();
            btnAceptar = new Button();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            cmbObraSocial = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtEdad = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 263);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 20;
            label3.Text = "Días de Internación";
            // 
            // txtDiaInternacion
            // 
            txtDiaInternacion.Location = new Point(24, 281);
            txtDiaInternacion.Name = "txtDiaInternacion";
            txtDiaInternacion.Size = new Size(234, 23);
            txtDiaInternacion.TabIndex = 19;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(163, 310);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 17;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(24, 141);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(234, 23);
            txtApellido.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 79);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 23);
            txtNombre.TabIndex = 14;
            // 
            // cmbObraSocial
            // 
            cmbObraSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObraSocial.FormattingEnabled = true;
            cmbObraSocial.Location = new Point(24, 53);
            cmbObraSocial.Name = "cmbObraSocial";
            cmbObraSocial.Size = new Size(234, 23);
            cmbObraSocial.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 35);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 22;
            label4.Text = "Obra Social";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 183);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 24;
            label5.Text = "carga la edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(24, 201);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(234, 23);
            txtEdad.TabIndex = 25;
            // 
            // frmNuevaInternacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 345);
            Controls.Add(txtEdad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbObraSocial);
            Controls.Add(label3);
            Controls.Add(txtDiaInternacion);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmNuevaInternacion";
            Text = "frmNuevaInternacion";
            Load += frmNuevaInternacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtDiaInternacion;
        private Button btnAceptar;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
        private ComboBox cmbObraSocial;
        private Label label4;
        private Label label5;
        private TextBox txtEdad;
    }
}