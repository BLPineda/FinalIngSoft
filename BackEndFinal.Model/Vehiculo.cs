using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Model
{
    public class Vehiculo
    {
        public int idVehiculo { get; set; }
        public int idDetalles { get; set; }
        public int idMarca { get; set; }
        public int idProveedor { get; set; }
        public int idVenta { get; set; }
        public int precio { get; set; }
        public bool disponibilidad { get; set; }
    }
}
