using eGameShop.Data.Enums;
using eGameShop.Data.Static;
using eGameShop.Models;
using Microsoft.AspNetCore.Identity;
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
							ProfilePictureURL = "https://scontent-waw1-1.xx.fbcdn.net/v/t1.6435-9/38405269_516502942106419_9099963392919076864_n.png?_nc_cat=106&ccb=1-7&_nc_sid=174925&_nc_ohc=aUyaBYqcgFkAX8ZAq7X&_nc_ht=scontent-waw1-1.xx&oh=00_AfD2za3lxmAJ4y78_YDKaZjuUkqERSp9kUFGcg7fnF-35w&oe=6410D227",
							Description = "Innersloth Studio"
						},
                        new Publisher()
                        {
                            FullName = "Activision",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/0/01/Activision.svg",
                            Description = "Activision Studio"
                        },
                        new Publisher()
                        {
							FullName = "Team Cherry",
							ProfilePictureURL = "https://scontent-waw1-1.xx.fbcdn.net/v/t39.30808-6/308129047_415753044006702_8201576346294109732_n.png?_nc_cat=101&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=hbZSf0ev8R4AX_6RV4B&_nc_ht=scontent-waw1-1.xx&oh=00_AfDlnwU1RzBHTLpDXXewfWm20XTN6LwWGPHJeXIvZULZ9A&oe=63EF2D3E",
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
                            ProfilePictureURL = "https://scontent-waw1-1.xx.fbcdn.net/v/t39.30808-6/308129047_415753044006702_8201576346294109732_n.png?_nc_cat=101&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=hbZSf0ev8R4AX_6RV4B&_nc_ht=scontent-waw1-1.xx&oh=00_AfDlnwU1RzBHTLpDXXewfWm20XTN6LwWGPHJeXIvZULZ9A&oe=63EF2D3E",
                            Description = "Team Cherry Studio"
                        },
                        new Producer()
                        {
                            FullName = "Treyarch",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/7/7a/Treyarch_logo.svg/220px-Treyarch_logo.svg.png",
                            Description = "Treyarch"
                        },
                        new Producer()
                        {
                            FullName = "Innersloth",
                            ProfilePictureURL = "https://scontent-waw1-1.xx.fbcdn.net/v/t1.6435-9/38405269_516502942106419_9099963392919076864_n.png?_nc_cat=106&ccb=1-7&_nc_sid=174925&_nc_ohc=aUyaBYqcgFkAX8ZAq7X&_nc_ht=scontent-waw1-1.xx&oh=00_AfD2za3lxmAJ4y78_YDKaZjuUkqERSp9kUFGcg7fnF-35w&oe=6410D227",
                            Description = "Innersloth Studio"
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
                        EndOfSale = DateTime.Now.AddDays(+15),
                        Quantity = 55,
                        GameCategory = GameCategory.Przygodowa,
                        PlatformId = 1,
                        DistributionPlatformId = 1,
                        PublisherId = 3
                        },
                        new Game()
                        {
                        Name = "Call of Duty: World at War",
                        Description = "Call of Duty is back, redefining war like you've never experienced before. " +
                        "Building on the Call of Duty 4®: Modern Warfare engine, " +
                        "Call of Duty: World at War immerses players into the most gritty and chaotic WWII combat ever experienced.",
                        ImageURL = "https://cdn.akamai.steamstatic.com/steam/apps/10090/header.jpg?t=1654830025",
                        Price = 25.99,
                        StartOfSale = DateTime.Now.AddDays(+4),
                        EndOfSale = DateTime.Now.AddDays(+18),
                        Quantity = 31,
                        GameCategory = GameCategory.Strzelanka,
                        PlatformId = 2,
                        DistributionPlatformId = 2,
                        PublisherId = 2
                        },
                        new Game()
                        {
                        Name = "Among US",
                        Description = "An online and local party game of teamwork and betrayal for 4-15 players...in space",
                        ImageURL = "https://cdn.akamai.steamstatic.com/steam/apps/945360/header.jpg?t=1673370035",
                        Price = 5.99,
                        StartOfSale = DateTime.Now.AddDays(-10),
                        EndOfSale = DateTime.Now.AddDays(+3),
                        Quantity = 13,
                        GameCategory = GameCategory.Akcja,
                        PlatformId = 3,
                        DistributionPlatformId = 4,
                        PublisherId = 1
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
                        PlatformId = 4,
                        DistributionPlatformId = 5,
                        PublisherId = 4
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

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }
                    

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@game.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        UserName = "admin",
                        Email = "admin@game.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "game123!@");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@game.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        UserName = "Appuser",
                        Email = "user@game.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "game123!@");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
