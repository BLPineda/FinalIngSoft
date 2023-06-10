using BackEndFinal.Data.Repositories;
using BackEndFinal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaController(PersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllPersona()
        {
            return Ok(await _personaRepository.GetAllPersona());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetPersonaDetails(int idPersona)
        {
            return Ok(await _personaRepository.GetDetails(idPersona));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersona([FromBody] Persona persona)
        {
            if (persona == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            var created = await _personaRepository.InsertPersona(persona);
            return Created("Creado", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePersona([FromBody] Persona persona)
        {
            if (persona == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            await _personaRepository.InsertPersona(persona);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePersona(int idPersona)
        {
            await _personaRepository.DeletePersona(new Persona { idPersona = idPersona });

            return NoContent();
        }
    }
}
