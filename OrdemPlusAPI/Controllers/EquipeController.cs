using Microsoft.AspNetCore.Mvc;
using OrdemPlus.Models;
using OrdemPlus.Services;
using System.Threading.Tasks;

namespace OrdemPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipeController : ControllerBase
    {
        private readonly IEquipeService _EquipeService;

        public EquipeController(IEquipeService EquipeService)
        {
            _EquipeService = EquipeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Equipes = await _EquipeService.GetAllEquipesAsync();
            return Ok(Equipes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Equipe = await _EquipeService.GetEquipeByIdAsync(id);
            if (Equipe == null)
            {
                return NotFound();
            }
            return Ok(Equipe);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Equipe Equipe)
        {
            await _EquipeService.AddEquipeAsync(Equipe);
            return CreatedAtAction(nameof(Get), new { id = Equipe.Id }, Equipe);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Equipe Equipe)
        {
            if (id != Equipe.Id)
                return BadRequest();

            await _EquipeService.UpdateEquipeAsync(Equipe);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _EquipeService.DeleteEquipeAsync(id);
            return NoContent();
        }
    }
}
