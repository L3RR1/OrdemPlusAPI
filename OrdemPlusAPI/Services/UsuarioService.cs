using OrdemPlus.Models;
using OrdemPlus.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdemPlus.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public UsuarioService(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuariosAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<Usuario> GetUsuarioByIdAsync(int id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task AddUsuarioAsync(Usuario usuario)
        {
            await _usuarioRepository.AddAsync(usuario);
            await _usuarioRepository.SaveAsync();
        }

        public async Task UpdateUsuarioAsync(Usuario usuario)
        {
            await _usuarioRepository.UpdateAsync(usuario);
            await _usuarioRepository.SaveAsync();
        }

        public async Task DeleteUsuarioAsync(int id)
        {
            await _usuarioRepository.DeleteAsync(id);
            await _usuarioRepository.SaveAsync();
        }
    }
}
