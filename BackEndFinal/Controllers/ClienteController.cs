using BackEndFinal.Data.Repositories;
using BackEndFinal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(ClienteRepository clienteRepository) {
        
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCliente()
        {
            return Ok(await _clienteRepository.GetAllClientes());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetClienteDetails(int idCliente)
        {
            return Ok(await _clienteRepository.GetDetails(idCliente));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCliente([FromBody] Cliente cliente)
        {
            if(cliente == null)
            {
                return BadRequest();
            }if (!ModelState.IsValid) { 
            
            return BadRequest(ModelState);
            }
            var created = await _clienteRepository.InsertCliente(cliente);
            return Created("Creado", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCliente ([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            await _clienteRepository.UpdateCliente(cliente);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCliente(int idCliente)
        {
            await _clienteRepository.DeleteCliente(new Cliente { idCliente = idCliente });

            return NoContent();
        }
    }
}
