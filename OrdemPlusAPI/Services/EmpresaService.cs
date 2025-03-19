using OrdemPlus.Models;
using OrdemPlus.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IRepository<Empresa> _empresaRepository;

        public EmpresaService(IRepository<Empresa> empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<IEnumerable<Empresa>> GetAllEmpresasAsync()
        {
            return await _empresaRepository.GetAllAsync();
        }

        public async Task<Empresa> GetEmpresaByIdAsync(int id)
        {
            return await _empresaRepository.GetByIdAsync(id);
        }

        public async Task AddEmpresaAsync(Empresa empresa)
        {
            await _empresaRepository.AddAsync(empresa);
            await _empresaRepository.SaveAsync();
        }

        public async Task UpdateEmpresaAsync(Empresa empresa)
        {
            await _empresaRepository.UpdateAsync(empresa);
            await _empresaRepository.SaveAsync();
        }

        public async Task DeleteEmpresaAsync(int id)
        {
            await _empresaRepository.DeleteAsync(id);
            await _empresaRepository.SaveAsync();
        }
    }
}
