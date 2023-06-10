using BackEndFinal.Data.Repositories;
using BackEndFinal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly VentaRepository _ventaRepository;

        public VentaController(VentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;   
        }

        [HttpGet]
        public async Task<ActionResult> GetAllVenta()
        {
            return Ok(await _ventaRepository.GetAllVenta());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetDetallesVenta(int idVenta)
        {
            return Ok(await _ventaRepository.GetDetails(idVenta));
        }

        [HttpPost]
        public async Task<IActionResult> CreateVenta([FromBody] Venta venta)
        {
            if (venta == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            var created = await _ventaRepository.InsertVenta(venta);
            return Created("Creado", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateVenta([FromBody] Venta venta)
        {
            if (venta == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            await _ventaRepository.UpdateVenta(venta);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVenta(int idVenta)
        {
            await _ventaRepository.DeleteVenta(new Venta { idVenta = idVenta });

            return NoContent();
        }
    }
}
