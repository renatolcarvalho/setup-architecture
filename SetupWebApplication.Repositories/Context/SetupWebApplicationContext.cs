using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SetupWebApplication.Repositories.Entities;

namespace SetupWebApplication.Repositories.Context
{
    public class SetupWebApplicationContext : DbContext
    {
        public SetupWebApplicationContext() : base("ExampleDB") { }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Conventions
            this.Configuration.LazyLoadingEnabled = true;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Defaults
            modelBuilder.Properties()
                .Where(p => p.ReflectedType != null && p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }
    }
}