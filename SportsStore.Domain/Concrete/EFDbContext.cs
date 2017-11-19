using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    class EFDbContextInicializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {   
        protected override void Seed(EFDbContext context)
        {
            List<Product> products = new List<Product>()
            {
                new Product 
                { 
                    Name = "Donic Indoor Roller 200",
                    Description = "Теннисный стол Donic Indoor Roller Fun Blue 19 мм.",
                    Price = 18990,
                    Category = "Теннисные столы"
                },

                new Product
                {
                    Name = "Start Line Club",
                    Description = "Белый мяч для настольного тенниса",
                    Price = 30,
                    Category = "Мячи для настольного тенниса"
                },

                new Product
                {
                    Name = "Start Line Club",
                    Description = "Белый мяч для настольного тенниса",
                    Price = 30,
                    Category = "Мячи для настольного тенниса"
                },

                new Product
                {
                    Name = "Torneo 2001",
                    Description = "Теннисный стол Torneo для закрытых помещений.",
                    Price = 7990,
                    Category = "Теннисные столы"
                },

                new Product
                {
                    Name = "Теннисный стол Kettler Axos Indoor 1",
                    Description = "Теннисный стол для закрытых помещений.",
                    Price = 13990,
                    Category = "Теннисные столы"
                },

                new Product
                {
                    Name = "Ракетка Double Fish CK-16",
                    Description = "Ракетка для настольного тенниса.",
                    Price = 590,
                    Category = "Ракетки для настольного тенниса"
                },

                new Product
                {
                    Name = "Ракетка Lavel 100",
                    Description = "Анатомическая ракетка для начинающих игроков.",
                    Price = 350,
                    Category = "Ракетки для настольного тенниса"
                },
            };

            foreach (Product p in products)
                context.Products.Add(p);

            context.SaveChanges();
        }
    }
    
    public class EFDbContext : DbContext
    {
        
        static EFDbContext()
        {
            Database.SetInitializer<EFDbContext>(new EFDbContextInicializer());
        }
        
        public EFDbContext() : base("EFDbContext") { }

        public DbSet<Product> Products { get; set; }
    }
}
