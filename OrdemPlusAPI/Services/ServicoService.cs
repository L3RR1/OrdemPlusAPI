using OrdemPlus.Models;
using OrdemPlus.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IRepository<Servico> _servicoRepository;

        public ServicoService(IRepository<Servico> servicoRepository)
        {
            _servicoRepository = servicoRepository;
        }

        public async Task<IEnumerable<Servico>> GetAllServicosAsync()
        {
            return await _servicoRepository.GetAllAsync();
        }

        public async Task<Servico> GetServicoByIdAsync(int id)
        {
            return await _servicoRepository.GetByIdAsync(id);
        }

        public async Task AddServicoAsync(Servico servico)
        {
            await _servicoRepository.AddAsync(servico);
            await _servicoRepository.SaveAsync();
        }

        public async Task UpdateServicoAsync(Servico servico)
        {
            await _servicoRepository.UpdateAsync(servico);
            await _servicoRepository.SaveAsync();
        }

        public async Task DeleteServicoAsync(int id)
        {
            await _servicoRepository.DeleteAsync(id);
            await _servicoRepository.SaveAsync();
        }
    }
}
