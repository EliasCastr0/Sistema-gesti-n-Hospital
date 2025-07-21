using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmObraSocial : Form
    {
        public frmObraSocial()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            if (valicacion2()) 
            {

                Hospital.Class.ObraSocial obra = new Class.ObraSocial()
                {
                    Nombre = "sin datos",
                    Porcentaje = 0
                };
                Hospital.Class.ObraSocial.ListObraSocial.Add(obra);

                this.Close();

            }




           
        }

        private bool valicacion2() 
        {
            if (string.IsNullOrWhiteSpace(txtNoombre.Text)) 
            {
                MessageBox.Show("ingrese un nombre");
                txtNoombre.Focus();
                return false;
            
            }

            if (string.IsNullOrWhiteSpace(txtPorcentaje.Text))
            {
                MessageBox.Show("ingrese un porcentaje");
                txtNoombre.Focus();
                return false;

            }


            return true;
        }
        
    }
}
