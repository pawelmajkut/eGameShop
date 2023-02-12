using eGameShop.Models;

namespace eGameShop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Platform
                if (!context.Platforms.Any())
                {
                    context.Platforms.AddRange(new List<Platform>()
                    {
                        new Platform()
                        {
                            Name = "PC",
                            Logo = "https://blob.stati.pl/x-kom/backoffice/salesarea/banners/pc_1649336692.jpg",
                            Description = "Games for PC players."
                        },
                        new Platform()
                        {
                            Name = "PS5",
                            Logo = "https://blob.stati.pl/x-kom/backoffice/salesarea/banners/ps_1649336692.jpg",
                            Description = "Games for PS5 players"
                        },
                        new Platform()
                        {
                            Name = "XBOX",
                            Logo = "https://blob.stati.pl/x-kom/backoffice/salesarea/banners/xbox_1649336692.jpg",
                            Description = "Games for XBOX players"
                        },
                        new Platform()
                        {
                            Name = "Nintendo",
                            Logo = "https://blob.stati.pl/x-kom/backoffice/salesarea/banners/nintendo_1649336692.jpg",
                            Description = "Games for Nintendo players"
                        },

                    });
                    context.SaveChanges();
                }
                //DistrubutionPlatforms
                if (!context.DistributionPlatforms.Any())
                {


                }
                //Publisher
                if (!context.Publisher.Any())
                {

                }
                //Game
                if (!context.Games.Any())
                {

                }
                //Producer
                if (!context.Producers.Any())
                {

                }
                //Producers & Games
                if (!context.Producers_Games.Any())
                {

                }


            }
        }

    }
}
