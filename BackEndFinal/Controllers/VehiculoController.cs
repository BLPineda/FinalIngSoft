using BackEndFinal.Data.Repositories;
using BackEndFinal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoRepository _vehiculoRepository;

        public VehiculoController(VehiculoRepository vehiculoRepository)
        {

            _vehiculoRepository = vehiculoRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllVehiculo()
        {
            return Ok(await _vehiculoRepository.GetAllVehiculo());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetVehiculoDetails(int idVehiculo)
        {
            return Ok(await _vehiculoRepository.GetDetails(idVehiculo));
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehiculo([FromBody] Vehiculo vehiculo)
        {
            if (vehiculo== null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            var created = await _vehiculoRepository.InsertVehiculo(vehiculo);
            return Created("Creado", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateVehiculo([FromBody] Vehiculo vehiculo)
        {
            if (vehiculo == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            await _vehiculoRepository.InsertVehiculo(vehiculo);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVehiculo(int idVehiculo)
        {
            await _vehiculoRepository.DeleteVehiculo(new Vehiculo { idVehiculo = idVehiculo });

            return NoContent();
        }
    }
}
