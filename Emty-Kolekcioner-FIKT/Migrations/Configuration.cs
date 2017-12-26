namespace Emty_Kolekcioner_FIKT.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Emty_Kolekcioner_FIKT.Models.OurDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Emty_Kolekcioner_FIKT.Models.OurDbContext";
        }

        protected override void Seed(Emty_Kolekcioner_FIKT.Models.OurDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
