using Microsoft.AspNetCore.Mvc;
using OrdemPlus.Models;
using OrdemPlus.Services;
using System.Threading.Tasks;

namespace OrdemPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _EmpresaService;

        public EmpresaController(IEmpresaService EmpresaService)
        {
            _EmpresaService = EmpresaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Empresas = await _EmpresaService.GetAllEmpresasAsync();
            return Ok(Empresas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Empresa = await _EmpresaService.GetEmpresaByIdAsync(id);
            if (Empresa == null)
            {
                return NotFound();
            }
            return Ok(Empresa);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Empresa Empresa)
        {
            await _EmpresaService.AddEmpresaAsync(Empresa);
            return CreatedAtAction(nameof(Get), new { id = Empresa.Id }, Empresa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Empresa Empresa)
        {
            if (id != Empresa.Id)
                return BadRequest();

            await _EmpresaService.UpdateEmpresaAsync(Empresa);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _EmpresaService.DeleteEmpresaAsync(id);
            return NoContent();
        }
    }
}
