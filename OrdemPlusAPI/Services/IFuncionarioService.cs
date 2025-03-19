using OrdemPlus.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public interface IFuncionarioService
    {
        Task<IEnumerable<Funcionario>> GetAllFuncionariosAsync();
        Task<Funcionario> GetFuncionarioByIdAsync(int id);
        Task AddFuncionarioAsync(Funcionario funcionario);
        Task UpdateFuncionarioAsync(Funcionario funcionario);
        Task DeleteFuncionarioAsync(int id);
    }
}
