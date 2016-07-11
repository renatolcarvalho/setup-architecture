using System.Collections.Generic;
using SetupWebApplication.Repositories.Entities;

namespace SetupWebApplication.Mapper
{
    public class RepositorieToModel
    {
        public static Models.Usuario UsuarioRepositorieToViewModel(Usuario usuario)
        {
            var usuarioViewModel = new Models.Usuario
            {
                UsuarioId = usuario.UsuarioId,
                Nome = usuario.Nome
            };

            return usuarioViewModel;
        }

        public static List<Models.Usuario> UsuariosRepositorieToViewModels(List<Usuario> usuarios)
        {
            var usuariosViewsModel = new List<Models.Usuario>();
            foreach (Usuario usuario in usuarios)
            {
                usuariosViewsModel.Add(new Models.Usuario
                {
                    UsuarioId = usuario.UsuarioId,
                    Nome = usuario.Nome
                });
            }

            return usuariosViewsModel;
        }
    }
}