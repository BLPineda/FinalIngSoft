using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedor>> GetAllProveedor();
        Task<Proveedor> GetDetails(int idProveedor);
        Task<bool> InsertProveedor(Proveedor proveedor);
        Task<bool> UpdateProveedor(Proveedor proveedor);
        Task<bool> DeleteProveedor(Proveedor proveedor);
    }
}
