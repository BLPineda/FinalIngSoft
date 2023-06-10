using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public interface IDetallesRepository
    {
        Task<IEnumerable<Detalles>> GetAllDetalles();
        Task<Detalles> GetDetails(int idDetalles);
        Task<bool> InsertDetalles(Detalles detalles);
        Task<bool> UpdateDetalles(Detalles detalles);
        Task<bool> DeleteDetalles(Detalles detalles);
    }
}
