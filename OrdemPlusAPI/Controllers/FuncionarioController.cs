using Microsoft.AspNetCore.Mvc;
using OrdemPlus.Models;
using OrdemPlus.Services;
using System.Threading.Tasks;

namespace OrdemPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _FuncionarioService;

        public FuncionarioController(IFuncionarioService FuncionarioService)
        {
            _FuncionarioService = FuncionarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Funcionarios = await _FuncionarioService.GetAllFuncionariosAsync();
            return Ok(Funcionarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Funcionario = await _FuncionarioService.GetFuncionarioByIdAsync(id);
            if (Funcionario == null)
            {
                return NotFound();
            }
            return Ok(Funcionario);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Funcionario Funcionario)
        {
            await _FuncionarioService.AddFuncionarioAsync(Funcionario);
            return CreatedAtAction(nameof(Get), new { id = Funcionario.Id }, Funcionario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Funcionario Funcionario)
        {
            if (id != Funcionario.Id)
                return BadRequest();

            await _FuncionarioService.UpdateFuncionarioAsync(Funcionario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _FuncionarioService.DeleteFuncionarioAsync(id);
            return NoContent();
        }
    }
}
