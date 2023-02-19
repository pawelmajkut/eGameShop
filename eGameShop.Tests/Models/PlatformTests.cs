using eGameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGameShop.Tests.Models
{
	public class PlatformTests
	{
		[Fact]
		public void Platform_Constructor_Sets_Name()
		{
			// Arrange
			string name = "Nintendo";
			string logo = "https://blob.stati.pl/x-kom/backoffice/salesarea/banners/nintendo_1649336692.jpg";
			string description = "Games for Nintendo players";

			// Act
			var platform = new Platform()
			{
				Name = name,
				Logo = logo,
				Description = description
			};

			// Assert
			Assert.Equal(name, platform.Name);
		}

		[Fact]
		public void Platform_Constructor_Sets_Logo()
		{
			// Arrange
			string name = "Nintendo";
			string logo = "https://blob.stati.pl/x-kom/backoffice/salesarea/banners/nintendo_1649336692.jpg";
			string description = "Games for Nintendo players";

			// Act
			var platform = new Platform()
			{
				Name = name,
				Logo = logo,
				Description = description
			};

			// Assert
			Assert.Equal(logo, platform.Logo);
		}

		[Fact]
		public void Platform_Constructor_Sets_Description()
		{
			// Arrange
			string name = "Nintendo";
			string logo = "https://blob.stati.pl/x-kom/backoffice/salesarea/banners/nintendo_1649336692.jpg";
			string description = "Games for Nintendo players";

			// Act
			var platform = new Platform() { Name = name, Logo = logo, Description = description };

			// Assert
			Assert.Equal(description, platform.Description);
		}
	}
}
