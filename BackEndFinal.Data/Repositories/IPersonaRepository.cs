using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetAllPersona();
        Task<Persona> GetDetails(int idPersona);
        Task<bool> InsertPersona(Persona persona);
        Task<bool> UpdatePersona(Persona persona);
        Task<bool> DeletePersona(Persona persona);
    }
}
