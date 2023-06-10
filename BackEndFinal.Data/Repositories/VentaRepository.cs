using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        public Task<bool> DeleteVenta(Venta venta)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Venta>> GetAllVenta()
        {
            throw new NotImplementedException();
        }

        public Task<Venta> GetDetails(int idVenta)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertVenta(Venta venta)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateVenta(Venta venta)
        {
            throw new NotImplementedException();
        }
    }
}
