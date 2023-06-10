using BackEndFinal.Data.Repositories;
using BackEndFinal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaController(MarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllMarca()
        {
            return Ok(await _marcaRepository.GetAllMarca());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetMarcaDetails(int idMarca)
        {
            return Ok(await _marcaRepository.GetDetails(idMarca));
        }

        [HttpPost]
        public async Task<IActionResult> CreateMarca([FromBody] Marca marca)
        {
            if (marca == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            var created = await _marcaRepository.InsertMarca(marca);
            return Created("Creado", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMarca([FromBody] Marca marca)
        {
            if (marca == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            await _marcaRepository.InsertMarca(marca);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMarca(int idMarca)
        {
            await _marcaRepository.DeleteMarca(new Marca { idMarca = idMarca });

            return NoContent();
        }
    }
}
