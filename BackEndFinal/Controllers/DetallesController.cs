using BackEndFinal.Data.Repositories;
using BackEndFinal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallesController : ControllerBase
    {
        private readonly IDetallesRepository _detallesRepository;

        public DetallesController(DetallesRepository detallesRepository)
        {
            _detallesRepository = detallesRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllDetalles()
        {
            return Ok(await _detallesRepository.GetAllDetalles());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetDetallesDetails(int idDetalles)
        {
            return Ok(await _detallesRepository.GetDetails(idDetalles));
        }

        [HttpPost]
        public async Task<IActionResult> CreateDetalles([FromBody] Detalles detallles)
        {
            if (detallles == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            var created = await _detallesRepository.InsertDetalles(detallles);
            return Created("Creado", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDetalles([FromBody] Detalles detalles)
        {
            if (detalles == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            await _detallesRepository.UpdateDetalles(detalles);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDetalles(int idDetalles)
        {
            await _detallesRepository.DeleteDetalles(new Detalles { idDetalles = idDetalles });

            return NoContent();
        }
    }
}
