using Server.Models;

namespace Server.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // make sures the database was created/ exists
            context.Database.EnsureCreated();

            // check if its empty
            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product { Id = 1, Category = "Fruits", Price = "$1", Stocked = true, Name = "Apple" },
                new Product { Id = 2, Category = "Fruits", Price = "$1", Stocked = true, Name = "Dragonfruit" },
                new Product { Id = 3, Category = "Fruits", Price = "$2", Stocked = false, Name = "Passionfruit" },
                new Product { Id = 4, Category = "Vegetables", Price = "$2", Stocked = true, Name = "Spinach" },
                new Product { Id = 5, Category = "Vegetables", Price = "$4", Stocked = false, Name = "Pumpkin" },
                new Product { Id = 6, Category = "Vegetables", Price = "$1", Stocked = true, Name = "Peas" }
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}