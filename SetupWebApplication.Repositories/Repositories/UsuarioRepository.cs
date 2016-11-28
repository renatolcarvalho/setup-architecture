using System.Collections.Generic;
using System.Linq;
using Dapper;
using SetupWebApplication.Repositories.Entities;
using SetupWebApplication.Repositories.Interfaces;

namespace SetupWebApplication.Repositories.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public override IEnumerable<Usuario> GetAll()
        {
            var cn = Db.Database.Connection;
            var items = cn.Query<Usuario>($"SELECT * FROM {typeof(Usuario).Name}");
            return items;
        }

        public override Usuario GetById(int id)
        {
            var cn = Db.Database.Connection;
            var item = cn.Query<Usuario>($"SELECT * FROM {typeof(Usuario).Name} WHERE {typeof(Usuario).Name}Id = {id}");
            return item.First();
        }
    }
}