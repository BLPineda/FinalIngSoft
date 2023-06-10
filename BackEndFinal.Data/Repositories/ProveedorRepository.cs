using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        public Task<bool> DeleteProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Proveedor>> GetAllProveedor()
        {
            throw new NotImplementedException();
        }

        public Task<Proveedor> GetDetails(int idProveedor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
    }
}
