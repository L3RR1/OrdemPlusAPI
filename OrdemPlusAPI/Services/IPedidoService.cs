using OrdemPlus.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> GetAllPedidosAsync();
        Task<Pedido> GetPedidoByIdAsync(int id);
        Task AddPedidoAsync(Pedido pedido);
        Task UpdatePedidoAsync(Pedido pedido);
        Task DeletePedidoAsync(int id);
    }
}
