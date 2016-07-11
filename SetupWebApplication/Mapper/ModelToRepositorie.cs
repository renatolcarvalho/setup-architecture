using System.Collections.Generic;
using SetupWebApplication.Models;

namespace SetupWebApplication.Mapper
{
    public class ModelToRepositorie
    {
        public static Repositories.Entities.Usuario UsuarioViewModelToRepositorie(Usuario usuario)
        {
            var usuarioRepository = new Repositories.Entities.Usuario
            {
                UsuarioId = usuario.UsuarioId,
                Nome = usuario.Nome
            };

            return usuarioRepository;
        }

        public static List<Repositories.Entities.Usuario> UsuariosViewModelToRepositories(List<Usuario> usuarios)
        {
            var usuariosRepository = new List<Repositories.Entities.Usuario>();
            foreach (Usuario usuario in usuarios)
            {
                usuariosRepository.Add(new Repositories.Entities.Usuario
                {
                    UsuarioId = usuario.UsuarioId,
                    Nome = usuario.Nome
                });
            }

            return usuariosRepository;
        }
    }
}