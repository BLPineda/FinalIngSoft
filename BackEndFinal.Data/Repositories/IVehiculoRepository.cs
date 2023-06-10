using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public interface IVehiculoRepository
    {
        Task<IEnumerable<Vehiculo>> GetAllVehiculo();
        Task<Vehiculo> GetDetails(int idVehiculo);
        Task<bool> InsertVehiculo(Vehiculo vehiculo);
        Task<bool> UpdateVehiculo(Vehiculo vehiculo);
        Task<bool> DeleteVehiculo(Vehiculo vehiculo);
    }
}
