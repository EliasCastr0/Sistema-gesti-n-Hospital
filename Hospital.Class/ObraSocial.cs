using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Class
{
    public class ObraSocial
    {
        public string Nombre { get; set; }
        public int Porcentaje { get; set; }

        public static List<ObraSocial> ListObraSocial { get; set; } = new List<ObraSocial>();
    }
}
