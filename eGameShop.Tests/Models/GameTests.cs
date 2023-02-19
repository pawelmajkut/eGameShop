using eGameShop.Data.Enums;
using eGameShop.Models;
using Xunit;

public class GameTests
{
	[Fact]
	public void GameConstructor_WithValidArguments_ShouldCreateNewGame()
	{
		// Arrange
		var name = "Game 1";
		var description = "Description of Game 1";
		var imageURL = "https://example.com/game1.jpg";
		var price = 29.99;
		var startOfSale = DateTime.Now.AddDays(1);
		var endOfSale = DateTime.Now.AddDays(10);
		var quantity = 100;
		var gameCategory = GameCategory.Przygodowa;
		var distributionPlatform = new DistributionPlatform()
		{
			Name = "Origin",
			Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Origin.svg/150px-Origin.svg.png",
			Description = "Origin platform"
		};
		var platform = new Platform()
		{
			Name = "Nintendo",
			Logo = "https://blob.stati.pl/x-kom/backoffice/salesarea/banners/nintendo_1649336692.jpg",
			Description = "Games for Nintendo players"
		};
		var publisher = new Publisher()
		{
			FullName = "Supergiant Games",
			ProfilePictureURL = "https://images.ctfassets.net/5owu3y35gz1g/515iBuHUzspUUF0fVrrTsR/919af2bab70c70204c423070ecb2c06a/logo_sg_final2.png?w=250&h=96&q=50&fit=fill",
			Description = "Supergiant Games Studio"
		};

		// Act
		var game = new Game
		{
			Name = name,
			Description = description,
			ImageURL = imageURL,
			Price = price,
			StartOfSale = startOfSale,
			EndOfSale = endOfSale,
			Quantity = quantity,
			GameCategory = gameCategory,
			DistributionPlatform = distributionPlatform,
			Platform = platform,
			Publisher = publisher
		};

		// Assert
		Assert.Equal(name, game.Name);
		Assert.Equal(description, game.Description);
		Assert.Equal(imageURL, game.ImageURL);
		Assert.Equal(price, game.Price);
		Assert.Equal(startOfSale, game.StartOfSale);
		Assert.Equal(endOfSale, game.EndOfSale);
		Assert.Equal(quantity, game.Quantity);
		Assert.Equal(gameCategory, game.GameCategory);
		Assert.Equal(distributionPlatform, game.DistributionPlatform);
		Assert.Equal(platform, game.Platform);
		Assert.Equal(publisher, game.Publisher);


	}

	
	

}
