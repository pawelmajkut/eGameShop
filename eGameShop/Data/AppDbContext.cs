using eGameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameShop.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producer_Game>().HasKey(pg => new
            {
                pg.ProducerId,
                pg.GameId
            });

            modelBuilder.Entity<Producer_Game>().HasOne(g => g.Game).WithMany(pg => pg.Producers_Games).HasForeignKey(g => g.GameId);

            modelBuilder.Entity<Producer_Game>().HasOne(g => g.Producer).WithMany(pg => pg.Producers_Games).HasForeignKey(g => g.ProducerId);

            


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Producer> Producers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Producer_Game> Producers_Games { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<DistributionPlatform> DistributionPlatforms { get; set; }  
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }    






    }
}
