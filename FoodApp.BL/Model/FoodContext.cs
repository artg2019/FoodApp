using FoodApp.BL.Model;
using System.Data.Entity;
namespace FoodApp.BL
{
    public class FoodContext : DbContext
    {
        public FoodContext() : base("DbConnection") { }

        public DbSet<FoodValue> FoodValues { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RecipteManual> RecipteManuals { get; set; }
        public DbSet<Recipte> Reciptes { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
    }
}
