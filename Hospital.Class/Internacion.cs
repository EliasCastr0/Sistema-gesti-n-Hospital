using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Class
{
    public class Internacion
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Dias { get; set; }
        public decimal Total { get; set; }

        public static List<Internacion> LstInternacion {  get; set; } = new List<Internacion>();
    }
}
