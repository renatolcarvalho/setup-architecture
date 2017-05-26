namespace App.Data.Migrations
{
    using System.Data.Entity.Migrations;
    internal sealed class Configuration : DbMigrationsConfiguration<Context.MainContext>
    {
        public Configuration() => AutomaticMigrationsEnabled = true;
        protected override void Seed(App.Data.Context.MainContext context) { }
    }
}