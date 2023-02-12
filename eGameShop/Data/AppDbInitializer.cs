using eGameShop.Data.Enums;
using eGameShop.Models;
using static System.Net.WebRequestMethods;

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
                    context.DistributionPlatforms.AddRange(new List<DistributionPlatform>()
                    {
                        new DistributionPlatform()
                        {
                            Name = "Steam",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Steam_icon_logo.svg/150px-Steam_icon_logo.svg.png",
                            Description = "Steam platform"
                        },
                        new DistributionPlatform()
                        {
                            Name = "GOG",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/GOG.com_logo.svg/196px-GOG.com_logo.svg.png",
                            Description = "GOG platform"
                        },
                        new DistributionPlatform()
                        {
                            Name = "Origin",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Origin.svg/150px-Origin.svg.png",
                            Description = "Origin platform"
                        },
                        new DistributionPlatform()
                        {
                            Name = "Amazon Game Studios",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d6/Amazon_Games_logo.svg/150px-Amazon_Games_logo.svg.png",
                            Description = "Amazon Game Studios platform"
                        },
                         new DistributionPlatform()
                        {
                            Name = "Blizzard Entertainment",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Blizzard_Entertainment_Logo_2015.svg/240px-Blizzard_Entertainment_Logo_2015.svg.png",
                            Description = "Blizard Entertainment platform"
                        },

                    });
                    context.SaveChanges();

                }
                //Publisher
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            FullName = "Innersloth",
                            ProfilePictureURL = "https://www.innersloth.com/wp-content/uploads/2021/07/SURPRISESLOTH.png",
                            Description = "Innersloth Studio"
                        },
                        new Publisher()
                        {
                            FullName = "Activision",
                            ProfilePictureURL = "https://www.activision.com/content/dam/atvi/global/firstparty/activision/activision_logo_white-text.png",
                            Description = "Activision Studio"
                        },
                        new Publisher()
                        {
                            FullName = "Team Cherry",
                            ProfilePictureURL = "https://images.squarespace-cdn.com/content/v1/606d4deb4db8c15ea53b3624/1618313425981-OKWEWRWP5D6WNQY7FQ8R/Team_Cherry_Logo_NoText_Small.png?format=1500w",
                            Description = "Team Cherry Studio"
                        },
                        new Publisher()
                        {
                            FullName = "Supergiant Games",
                            ProfilePictureURL = "https://images.ctfassets.net/5owu3y35gz1g/515iBuHUzspUUF0fVrrTsR/919af2bab70c70204c423070ecb2c06a/logo_sg_final2.png?w=250&h=96&q=50&fit=fill",
                            Description = "Supergiant Games Studio"
                        },
                    });
                    context.SaveChanges();
                }
                //Game
                if (!context.Games.Any())
                {
                    context.Games.AddRange(new List<Game>()
                    {
                        new Game()
                        {
                        Name = "Hollow Knight",
                        Description = "Forge your own path in Hollow Knight! An epic action adventure through a vast ruined kingdom of insects and heroes. " +
                        "Explore twisting caverns, battle tainted creatures and befriend bizarre bugs, all in a classic, hand-drawn 2D style.",
                        ImageURL = "https://cdn.akamai.steamstatic.com/steam/apps/367520/header.jpg?t=1667006028",
                        Price = 12.99,
                        StartOfSale = DateTime.Now.AddDays(-12),
                        EndOfSale = DateTime.Now.AddDays(-2),
                        Quantity = 55,
                        GameCategory = GameCategory.Przygodowa,
                        Platform = PlatformCategory.PC,
                        },
                        new Game()
                        {
                        Name = "Call of Duty: World at War",
                        Description = "Call of Duty is back, redefining war like you've never experienced before. " +
                        "Building on the Call of Duty 4®: Modern Warfare engine, " +
                        "Call of Duty: World at War immerses players into the most gritty and chaotic WWII combat ever experienced.",
                        ImageURL = "https://cdn.akamai.steamstatic.com/steam/apps/10090/header.jpg?t=1654830025",
                        Price = 25.99,
                        StartOfSale = DateTime.Now.AddDays(-18),
                        EndOfSale = DateTime.Now.AddDays(-3),
                        Quantity = 31,
                        GameCategory = GameCategory.Strzelanka,
                        Platform = PlatformCategory.PC,
                        },
                        new Game()
                        {
                        Name = "Among US",
                        Description = "An online and local party game of teamwork and betrayal for 4-15 players...in space",
                        ImageURL = "https://cdn.akamai.steamstatic.com/steam/apps/945360/header.jpg?t=1673370035",
                        Price = 5.99,
                        StartOfSale = DateTime.Now.AddDays(-11),
                        EndOfSale = DateTime.Now.AddDays(-4),
                        Quantity = 13,
                        GameCategory = GameCategory.Akcja,
                        Platform = PlatformCategory.PS5,
                        },
                        new Game()
                        {
                        Name = "Hades",
                        Description = "Defy the god of the dead as you hack and slash out of the Underworld " +
                        "in this rogue-like dungeon crawler from the creators of Bastion, Transistor, and Pyre.",
                        ImageURL = "https://cdn.akamai.steamstatic.com/steam/apps/1145360/header.jpg?t=1670649855",
                        Price = 29.99,
                        StartOfSale = DateTime.Now.AddDays(-19),
                        EndOfSale = DateTime.Now.AddDays(-1),
                        Quantity = 18,
                        GameCategory = GameCategory.Akcja,
                        Platform = PlatformCategory.XBOX,
                        },
                                                
                });


                    context.SaveChanges();
                }
                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Supergiant Games",
                            ProfilePictureURL = "https://images.ctfassets.net/5owu3y35gz1g/515iBuHUzspUUF0fVrrTsR/919af2bab70c70204c423070ecb2c06a/logo_sg_final2.png?w=250&h=96&q=50&fit=fill",
                            Description = "Supergiant Games Studio"
                        },
                        new Producer()
                        {
                            FullName = "Team Cherry",
                            ProfilePictureURL = "https://images.squarespace-cdn.com/content/v1/606d4deb4db8c15ea53b3624/1618313425981-OKWEWRWP5D6WNQY7FQ8R/Team_Cherry_Logo_NoText_Small.png?format=1500w",
                            Description = "Team Cherry Studio"
                        },
                        new Producer()
                        {
                            FullName = "Treyarch",
                            ProfilePictureURL = "https://www.treyarch.com/content/dam/atvi/treyarch/treyarch-touchui/common/treyarch-logo.png",
                            Description = "Treyarch"
                        },
                        new Producer()
                        {
                            FullName = "Innersloth",
                            ProfilePictureURL = "https://www.innersloth.com/wp-content/uploads/2021/07/SURPRISESLOTH.png",
                            Description = "Innersloth Studio"
                        },


                    });

                    context.SaveChanges();
                }
                //Producers & Games
                if (!context.Producers_Games.Any())
                {
                    context.Producers_Games.AddRange(new List<Producer_Game>()
                    {
                    new Producer_Game()
                    {
                        GameId = 1,
                        ProducerId = 2
                    },
                    new Producer_Game()
                    {
                        GameId = 2,
                        ProducerId = 3
                    },
                    new Producer_Game()
                    {
                        GameId = 3,
                        ProducerId = 4 
                    },
                    new Producer_Game()
                    {
                        GameId = 4,
                        ProducerId = 1
                    },

                    });

                context.SaveChanges();
            }


            }
        }

    }
}
