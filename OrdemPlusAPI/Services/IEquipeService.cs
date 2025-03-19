using OrdemPlus.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public interface IEquipeService
    {
        Task<IEnumerable<Equipe>> GetAllEquipesAsync();
        Task<Equipe> GetEquipeByIdAsync(int id);
        Task AddEquipeAsync(Equipe equipe);
        Task UpdateEquipeAsync(Equipe equipe);
        Task DeleteEquipeAsync(int id);
    }
}
