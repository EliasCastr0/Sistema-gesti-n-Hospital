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
    public partial class frmNuevaInternacion : Form
    {
        public frmNuevaInternacion()
        {
            InitializeComponent();
        }

        private Hospital.Class.Internacion internacion = new Class.Internacion();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Hospital.Class.Internacion.LstInternacion.Add(internacion);
            if (validarr()) 
            {
              internacion.Nombre= txtNombre.Text;
                internacion.Apellido= txtApellido.Text;
                internacion.Dias=txtDiaInternacion.Text;
                internacion.Edad = Convert.ToInt32(txtEdad.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();

                decimal porcentaje = Convert.ToDecimal(cmbObraSocial.SelectedValue);

                internacion.Total = 75000;
                internacion.Total = (internacion.Total * porcentaje) / 100;
                Hospital.Class.Internacion.LstInternacion.Add(internacion);
                this.DialogResult = DialogResult.OK;
                this.Close();




            }




        }
        private bool validarr()
        {
           
          if (string.IsNullOrWhiteSpace(txtNombre.Text)) 
          {
                MessageBox.Show("debe de ingresar un nombre");
                txtNombre.Focus();
                return false;
          }

          if (string.IsNullOrWhiteSpace(txtApellido.Text)) 
          {
                MessageBox.Show("debe de ingresar un apellido");
                txtNombre.Focus();
                return false;

          }

          if (string.IsNullOrWhiteSpace(txtDiaInternacion.Text))
          {
                MessageBox.Show("debe de ingresar un dia de internacion");
                txtNombre.Focus();
                return false;


          }
            
            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("debe de ingresar una edad");
                txtNombre.Focus();
                return false;


            }



            return true;
        }


        private void CargarObraSocial()
        {
            cmbObraSocial.DisplayMember = "Nombre";
            cmbObraSocial.ValueMember = "Porcentaje";
            cmbObraSocial.DataSource = Hospital.Class.ObraSocial.ListObraSocial;
            
        
        }
        private void frmNuevaInternacion_Load(object sender, EventArgs e)
        {

            CargarObraSocial();
        }
    }


}
