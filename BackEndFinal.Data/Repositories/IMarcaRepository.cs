using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public interface IMarcaRepository
    {
        Task<IEnumerable<Marca>> GetAllMarca();
        Task<Marca> GetDetails(int idMarca);
        Task<bool> InsertMarca(Marca marca);
        Task<bool> UpdateMarca(Marca marca);
        Task<bool> DeleteMarca(Marca marca);
    }
}