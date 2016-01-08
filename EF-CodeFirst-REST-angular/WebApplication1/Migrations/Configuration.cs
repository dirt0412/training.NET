namespace WebApplication1.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Rezerwacjes.AddOrUpdate(
              p => p.Id,
              new Rezerwacje { Cena=100.70M , DataZameldowaniaWymeldowania=DateTime.Now, DatyUtworzenia=DateTime.Now, IdGosc=1, KodRezerwacji="W323123432", Prowizja=2 },
              new Rezerwacje { Cena = 200.40M, DataZameldowaniaWymeldowania = DateTime.Now, DatyUtworzenia = DateTime.Now, IdGosc = 1, KodRezerwacji = "W323000082", Prowizja = 6 },
              new Rezerwacje { Cena = 300.50M, DataZameldowaniaWymeldowania = DateTime.Now, DatyUtworzenia = DateTime.Now, IdGosc = 2, KodRezerwacji = "W323198711", Prowizja = 3 }
            );
            context.Goscies.AddOrUpdate(
                p=>p.Id,
                new Goscie { Email="test1@test.com", Imie="Pawe³", Nazwisko="Kowalski1" },
                new Goscie { Email = "test2@test.com", Imie = "Pawe³", Nazwisko = "Kowalski2" },
                new Goscie { Email = "test3@test.com", Imie = "Pawe³", Nazwisko = "Kowalski3" }
                );
            //
        }
    }
}
