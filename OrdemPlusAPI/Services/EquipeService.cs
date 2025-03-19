using OrdemPlus.Models;
using OrdemPlus.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public class EquipeService : IEquipeService
    {
        private readonly IRepository<Equipe> _equipeRepository;

        public EquipeService(IRepository<Equipe> equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }

        public async Task<IEnumerable<Equipe>> GetAllEquipesAsync()
        {
            return await _equipeRepository.GetAllAsync();
        }

        public async Task<Equipe> GetEquipeByIdAsync(int id)
        {
            return await _equipeRepository.GetByIdAsync(id);
        }

        public async Task AddEquipeAsync(Equipe equipe)
        {
            await _equipeRepository.AddAsync(equipe);
            await _equipeRepository.SaveAsync();
        }

        public async Task UpdateEquipeAsync(Equipe equipe)
        {
            await _equipeRepository.UpdateAsync(equipe);
            await _equipeRepository.SaveAsync();
        }

        public async Task DeleteEquipeAsync(int id)
        {
            await _equipeRepository.DeleteAsync(id);
            await _equipeRepository.SaveAsync();
        }
    }
}
