namespace Hospital
{
    partial class frmInternaciones
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
            dgvInternaciones = new DataGridView();
            Internado = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            DiasInt = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInternaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvInternaciones
            // 
            dgvInternaciones.AllowUserToAddRows = false;
            dgvInternaciones.AllowUserToDeleteRows = false;
            dgvInternaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternaciones.Columns.AddRange(new DataGridViewColumn[] { Internado, Edad, DiasInt, Total });
            dgvInternaciones.Dock = DockStyle.Fill;
            dgvInternaciones.Location = new Point(0, 0);
            dgvInternaciones.Name = "dgvInternaciones";
            dgvInternaciones.ReadOnly = true;
            dgvInternaciones.RowHeadersVisible = false;
            dgvInternaciones.RowTemplate.Height = 25;
            dgvInternaciones.Size = new Size(627, 379);
            dgvInternaciones.TabIndex = 0;
            // 
            // Internado
            // 
            Internado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Internado.HeaderText = "Internado";
            Internado.Name = "Internado";
            Internado.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            Edad.Width = 58;
            // 
            // DiasInt
            // 
            DiasInt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiasInt.HeaderText = "Días Int.";
            DiasInt.Name = "DiasInt";
            DiasInt.ReadOnly = true;
            DiasInt.Width = 74;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // frmInternaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 379);
            Controls.Add(dgvInternaciones);
            Name = "frmInternaciones";
            Text = "Nueva Internación";
            Load += frmInternaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInternaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInternaciones;
        private DataGridViewTextBoxColumn Internado;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn DiasInt;
        private DataGridViewTextBoxColumn Total;
    }
}