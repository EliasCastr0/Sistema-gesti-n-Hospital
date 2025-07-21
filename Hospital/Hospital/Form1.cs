namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AgregarObrasSociales();
        }

        private void AgregarObrasSociales()
        {
            Hospital.Class.ObraSocial obra1 = new Class.ObraSocial()
            {
                Nombre = "Sancor Salud",
                Porcentaje = 80
            };
            Hospital.Class.ObraSocial.ListObraSocial.Add(obra1);
            Hospital.Class.ObraSocial obra2 = new Class.ObraSocial()
            {
                Nombre = "Apross",
                Porcentaje = 50
            };
            Hospital.Class.ObraSocial.ListObraSocial.Add(obra2);
            Hospital.Class.ObraSocial obra3 = new Class.ObraSocial()
            {
                Nombre = "Metlife",
                Porcentaje = 90
            };
            Hospital.Class.ObraSocial.ListObraSocial.Add(obra3);


        }

        private void btnNuevaInternacion_Click(object sender, EventArgs e)
        {
            frmNuevaInternacion frm = new frmNuevaInternacion();
            frm.ShowDialog();
        }

        private void btnObraSocial_Click(object sender, EventArgs e)
        {
            frmObraSocial frm2 = new frmObraSocial();
            frm2.ShowDialog();

        }

        private void btnInternados_Click(object sender, EventArgs e)
        {
            frmInternaciones frm = new frmInternaciones();
            frm.ShowDialog();
        }
    }
}
