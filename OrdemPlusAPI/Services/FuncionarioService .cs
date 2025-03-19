using OrdemPlus.Models;
using OrdemPlus.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IRepository<Funcionario> _funcionarioRepository;

        public FuncionarioService(IRepository<Funcionario> funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task<IEnumerable<Funcionario>> GetAllFuncionariosAsync()
        {
            return await _funcionarioRepository.GetAllAsync();
        }

        public async Task<Funcionario> GetFuncionarioByIdAsync(int id)
        {
            return await _funcionarioRepository.GetByIdAsync(id);
        }

        public async Task AddFuncionarioAsync(Funcionario funcionario)
        {
            await _funcionarioRepository.AddAsync(funcionario);
            await _funcionarioRepository.SaveAsync();
        }

        public async Task UpdateFuncionarioAsync(Funcionario funcionario)
        {
            await _funcionarioRepository.UpdateAsync(funcionario);
            await _funcionarioRepository.SaveAsync();
        }

        public async Task DeleteFuncionarioAsync(int id)
        {
            await _funcionarioRepository.DeleteAsync(id);
            await _funcionarioRepository.SaveAsync();
        }
    }
}
