namespace GetApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Routing;

    internal sealed class Configuration : DbMigrationsConfiguration<GetApp.Models.GetModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed= true;
        }

        protected override void Seed(GetApp.Models.GetModel context)
        {
            context.ManegerSeniorities.AddOrUpdate(x => x.ID, new Models.ManegerSeniority() { ID = 1, Name = "Admin" });
            context.Manegers.AddOrUpdate(x => x.ID, new Models.Maneger() { ID = 1, Name = "Ufuk", Surname = "Gömeçoğlu", Mail = "ufuk.gomecoglu@gmail.com", ManegerSeniority_ID = 1, Password = "12345678", UserName = "u.gomecogllu", IsActive = true });
            context.RetailerSeniorities.AddOrUpdate(x => x.ID, new Models.RetailerSeniority { ID = 1, Name = "VIR" });
            context.RetailerSeniorities.AddOrUpdate(x => x.ID, new Models.RetailerSeniority { ID = 2, Name = "IR" });
            context.RetailerSeniorities.AddOrUpdate(x => x.ID, new Models.RetailerSeniority { ID = 3, Name = "R" });
        }
    }
}
