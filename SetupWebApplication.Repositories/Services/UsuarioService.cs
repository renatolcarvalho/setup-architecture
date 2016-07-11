using SetupWebApplication.Repositories.Entities;
using SetupWebApplication.Repositories.Interfaces;

namespace SetupWebApplication.Repositories.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository) { }
    }
}
