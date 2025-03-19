using OrdemPlus.Models;
using OrdemPlus.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IRepository<Pedido> _pedidoRepository;

        public PedidoService(IRepository<Pedido> pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<IEnumerable<Pedido>> GetAllPedidosAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        public async Task<Pedido> GetPedidoByIdAsync(int id)
        {
            return await _pedidoRepository.GetByIdAsync(id);
        }

        public async Task AddPedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.AddAsync(pedido);
            await _pedidoRepository.SaveAsync();
        }

        public async Task UpdatePedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.UpdateAsync(pedido);
            await _pedidoRepository.SaveAsync();
        }

        public async Task DeletePedidoAsync(int id)
        {
            await _pedidoRepository.DeleteAsync(id);
            await _pedidoRepository.SaveAsync();
        }
    }
}
