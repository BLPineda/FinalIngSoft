using BackEndFinal.Data.Repositories;
using BackEndFinal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorRepository _proveedorRepository;

        public ProveedorController(ProveedorRepository proveedorRepository)
        {

            _proveedorRepository = proveedorRepository;

        }

        [HttpGet]
        public async Task<ActionResult> GetAllProveedor()
        {
            return Ok(await _proveedorRepository.GetAllProveedor());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetPersonaDetails(int idProveedor)
        {
            return Ok(await _proveedorRepository.GetDetails(idProveedor));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProveedor([FromBody] Proveedor proveedor)
        {
            if (proveedor == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            var created = await _proveedorRepository.InsertProveedor(proveedor);
            return Created("Creado", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProveedor([FromBody] Proveedor proveedor)
        {
            if (proveedor == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            await _proveedorRepository.InsertProveedor(proveedor);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProveedor(int idProveedor)
        {
            await _proveedorRepository.DeleteProveedor(new Proveedor{ idProveedor = idProveedor });

            return NoContent();
        }
    }
}
