using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public interface IVentaRepository
    {
        Task<IEnumerable<Venta>> GetAllVenta();
        Task<Venta> GetDetails(int idVenta);
        Task<bool> InsertVenta(Venta venta);
        Task<bool> UpdateVenta(Venta venta);
        Task<bool> DeleteVenta(Venta venta);
    }
}
