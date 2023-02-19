using eGameShop.Controllers;
using eGameShop.Data.Enums;
using eGameShop.Data.Services;
using eGameShop.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGameShop.Tests.Models
{
	public class GameControlerTests
	{
		private readonly Mock<IGamesService> _serviceMock;
		private readonly GamesController _controller;

		public  GameControlerTests()
		{
			_serviceMock = new Mock<IGamesService>();
			_controller = new GamesController(_serviceMock.Object);
		}

		[Fact]
		public async Task Index_ReturnsAViewResult_WithListOfGames()
		{
			// Arrange
			var games = new List<Game>
			{
				new Game { Id = 1, Name = "Game 1" },
				new Game { Id = 2, Name = "Game 2" }
			};
			_serviceMock.Setup(repo => repo.GetAllAsync(n => n.Publisher)).ReturnsAsync(games);

			// Act
			var result = await _controller.Index();

			// Assert
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<IEnumerable<Game>>(viewResult.ViewData.Model);
			Assert.Equal(2, model.Count());
		}

		[Fact]
		public async Task Filter_ReturnsAViewResult_WithFilteredGames()
		{
			// Arrange
			var games = new List<Game>
			{
				new Game { Id = 1, Name = "Game 1", Description = "Action game", GameCategory = GameCategory.Przygodowa },
				new Game { Id = 2, Name = "Game 2", Description = "Sports game", GameCategory = GameCategory.Strzelanka },
				new Game { Id = 3, Name = "Game 3", Description = "Racing game", GameCategory = GameCategory.RPG }
			};
			_serviceMock.Setup(repo => repo.GetAllAsync(n => n.Publisher)).ReturnsAsync(games);

			// Act
			var result = await _controller.Filter("action", 1, 10);

			// Assert
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<IEnumerable<Game>>(viewResult.ViewData.Model);
			Assert.Single(model);
			Assert.Equal(1, model.First().Id);
		}

		[Fact]
		public async Task Create_WithValidModel_RedirectsToIndex()
		{
			// Arrange
			var game = new NewGameVM
			{
				Name = "Game 1",
				Description = "Action game",
				Price = 19.99
			};

			// Act
			var result = await _controller.Create(game);

			// Assert
			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Equal("Index", redirectToActionResult.ActionName);
		}
	}
}
