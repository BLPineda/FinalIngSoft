using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        public Task<bool> DeleteMarca(Marca marca)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Marca>> GetAllMarca()
        {
            throw new NotImplementedException();
        }

        public Task<Marca> GetDetails(int idMarca)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertMarca(Marca marca)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMarca(Marca marca)
        {
            throw new NotImplementedException();
        }
    }
}
