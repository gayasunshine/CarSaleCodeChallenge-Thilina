using CarSale.CodeChallenge.Database.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace CarSale.CodeChallenge.Database
{
    public partial class CarSaleCodeChallengeContext : DbContext
    {
        public CarSaleCodeChallengeContext()
        {
        }

        public CarSaleCodeChallengeContext(DbContextOptions<CarSaleCodeChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
