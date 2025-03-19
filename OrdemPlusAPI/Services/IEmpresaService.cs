using OrdemPlus.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public interface IEmpresaService
    {
        Task<IEnumerable<Empresa>> GetAllEmpresasAsync();
        Task<Empresa> GetEmpresaByIdAsync(int id);
        Task AddEmpresaAsync(Empresa empresa);
        Task UpdateEmpresaAsync(Empresa empresa);
        Task DeleteEmpresaAsync(int id);
    }
}
