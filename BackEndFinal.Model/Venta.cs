using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Model
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public decimal impuestos { get; set; }
        public decimal ganancia { get; set; }
        public decimal precioFinal { get; set; }
    }
}
