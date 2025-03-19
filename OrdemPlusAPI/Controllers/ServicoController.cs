using Microsoft.AspNetCore.Mvc;
using OrdemPlus.Models;
using OrdemPlus.Services;
using System.Threading.Tasks;

namespace OrdemPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicoController : ControllerBase
    {
        private readonly IServicoService _servicoService;

        public ServicoController(IServicoService servicoService)
        {
            _servicoService = servicoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var servicos = await _servicoService.GetAllServicosAsync();
            return Ok(servicos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var servico = await _servicoService.GetServicoByIdAsync(id);
            if (servico == null)
            {
                return NotFound();
            }
            return Ok(servico);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Servico servico)
        {
            await _servicoService.AddServicoAsync(servico);
            return CreatedAtAction(nameof(Get), new { id = servico.Id }, servico);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Servico servico)
        {
            if (id != servico.Id)
                return BadRequest();

            await _servicoService.UpdateServicoAsync(servico);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _servicoService.DeleteServicoAsync(id);
            return NoContent();
        }
    }
}
