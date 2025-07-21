using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmInternaciones : Form
    {
        public frmInternaciones()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        


        private void frmInternaciones_Load(object sender, EventArgs e)
        {

            if (Hospital.Class.Internacion.LstInternacion.Count > 0)
            {
                foreach (var item in Hospital.Class.Internacion.LstInternacion)
                {
                    dgvInternaciones.Rows.Add(item.Apellido + ", " + item.Nombre, item.Edad, item.Dias, item.Total);
                }
            }
        }
    }
}
