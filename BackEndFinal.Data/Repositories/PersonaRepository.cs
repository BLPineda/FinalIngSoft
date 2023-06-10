using BackEndFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        public Task<bool> DeletePersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Persona>> GetAllPersona()
        {
            throw new NotImplementedException();
        }

        public Task<Persona> GetDetails(int idPersona)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
