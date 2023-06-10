using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Model
{
    public class Detalles
    {
        public int idDetalles { get; set; }
        public int modelo { get; set; }
        public string color { get; set; }
        //Variable que indica si el vehiculo es nuevo, usado o seminuevo
        public string estado { get; set; }
    }
}
