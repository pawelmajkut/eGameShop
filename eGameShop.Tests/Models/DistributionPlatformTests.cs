using eGameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGameShop.Tests.Models
{
	public class DistributionPlatformTests
	{
		[Fact]
		public void DistributionPlatform_DefaultConstructor_ShouldCreateNewInstance()
		{
			// Arrange
			// Act
			var distributionPlatform = new DistributionPlatform();

			// Assert
			Assert.NotNull(distributionPlatform);
			Assert.IsType<DistributionPlatform>(distributionPlatform);
		}

		[Fact]
		public void DistributionPlatform_ConstructorWithParams_ShouldSetProperties()
		{
			// Arrange
			string name = "Origin";
			string logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Origin.svg/150px-Origin.svg.png";
			string description = "Origin platform";

			// Act
			var distributionPlatform = new DistributionPlatform()
			{
				Name = name,
				Logo = logo,
				Description = description
			};

			// Assert
			Assert.Equal(name, distributionPlatform.Name);
			Assert.Equal(logo, distributionPlatform.Logo);
			Assert.Equal(description, distributionPlatform.Description);
		}
	}
}
