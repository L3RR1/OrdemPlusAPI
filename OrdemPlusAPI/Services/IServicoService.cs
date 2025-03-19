using OrdemPlus.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public interface IServicoService
    {
        Task<IEnumerable<Servico>> GetAllServicosAsync();
        Task<Servico> GetServicoByIdAsync(int id);
        Task AddServicoAsync(Servico servico);
        Task UpdateServicoAsync(Servico servico);
        Task DeleteServicoAsync(int id);
    }
}
