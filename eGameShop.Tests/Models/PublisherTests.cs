using eGameShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGameShop.Tests.Models
{
		public class PublisherTests
		{
			[Fact]
			public void CanCreatePublisher()
			{
				// Arrange
				var publisher = new Publisher
				{
					FullName = "Supergiant Games",
					ProfilePictureURL = "https://images.ctfassets.net/5owu3y35gz1g/515iBuHUzspUUF0fVrrTsR/919af2bab70c70204c423070ecb2c06a/logo_sg_final2.png?w=250&h=96&q=50&fit=fill",
					Description = "Supergiant Games Studio"
				};

				// Assert
				Assert.NotNull(publisher);
				Assert.Equal("Supergiant Games", publisher.FullName);
				Assert.Equal("https://images.ctfassets.net/5owu3y35gz1g/515iBuHUzspUUF0fVrrTsR/919af2bab70c70204c423070ecb2c06a/logo_sg_final2.png?w=250&h=96&q=50&fit=fill", publisher.ProfilePictureURL);
				Assert.Equal("Supergiant Games Studio", publisher.Description);
			}
		}
	
}
