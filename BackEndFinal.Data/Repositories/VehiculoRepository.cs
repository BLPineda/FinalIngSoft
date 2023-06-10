using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public class VehiculoRepository : IVehiculoRepository
    {
        public Task<bool> DeleteVehiculo(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehiculo>> GetAllVehiculo()
        {
            throw new NotImplementedException();
        }

        public Task<Vehiculo> GetDetails(int idVehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertVehiculo(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateVehiculo(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }
    }
}
