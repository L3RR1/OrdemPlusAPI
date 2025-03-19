using Microsoft.AspNetCore.Mvc;
using OrdemPlus.Models;
using OrdemPlus.Services;
using System.Threading.Tasks;

namespace OrdemPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _PedidoService;

        public PedidoController(IPedidoService PedidoService)
        {
            _PedidoService = PedidoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Pedidos = await _PedidoService.GetAllPedidosAsync();
            return Ok(Pedidos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Pedido = await _PedidoService.GetPedidoByIdAsync(id);
            if (Pedido == null)
            {
                return NotFound();
            }
            return Ok(Pedido);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Pedido Pedido)
        {
            await _PedidoService.AddPedidoAsync(Pedido);
            return CreatedAtAction(nameof(Get), new { id = Pedido.Id }, Pedido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Pedido Pedido)
        {
            if (id != Pedido.Id)
                return BadRequest();

            await _PedidoService.UpdatePedidoAsync(Pedido);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _PedidoService.DeletePedidoAsync(id);
            return NoContent();
        }
    }
}
