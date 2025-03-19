using Microsoft.AspNetCore.Mvc;
using OrdemPlus.Models;
using OrdemPlus.Services;
using System.Threading.Tasks;

namespace OrdemPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _UsuarioService;

        public UsuarioController(IUsuarioService UsuarioService)
        {
            _UsuarioService = UsuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Usuarios = await _UsuarioService.GetAllUsuariosAsync();
            return Ok(Usuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Usuario = await _UsuarioService.GetUsuarioByIdAsync(id);
            if (Usuario == null)
            {
                return NotFound();
            }
            return Ok(Usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario Usuario)
        {
            await _UsuarioService.AddUsuarioAsync(Usuario);
            return CreatedAtAction(nameof(Get), new { id = Usuario.Id }, Usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Usuario Usuario)
        {
            if (id != Usuario.Id)
                return BadRequest();

            await _UsuarioService.UpdateUsuarioAsync(Usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _UsuarioService.DeleteUsuarioAsync(id);
            return NoContent();
        }
    }
}
