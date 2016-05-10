using System;
using System.Configuration;
using mdryden.cflapi.v1.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace mdryden.cflapi.v1.ClientTests
{
	[TestClass]
	public class CflApiClientTests
	{

		private CflApiClient GetClient()
		{
			var apiKey = ConfigurationManager.AppSettings["apiKey"];

			return new CflApiClient(apiKey);
		}

		[TestMethod]
		public void GetFirst20GamesTest()
		{
			var client = GetClient();

			var games = client.GetGames();

			var expected = 20;
			var actual = games.Count();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetNext20GamesTest()
		{
			var client = GetClient();

			var games = client.GetGames(2, 20);

			var expected = 40;
			var actual = games.Last().GameNumber;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetGame2221Test()
		{
			var client = GetClient();

			var game = client.GetGame(2015, 2221, false, false);

			var expected = 2221;
			var actual = game.GameId;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetGame2221BoxscoreTest()
		{
			var client = GetClient();

			var game = client.GetGame(2015, 2221, true, false);

			Assert.IsNotNull(game.Boxscore);
		}

		[TestMethod]
		public void GetGame2221PlayByPlayTest()
		{
			var client = GetClient();

			var game = client.GetGame(2015, 2221, false, true);

			Assert.IsNotNull(game.PlayByPlay);
		}

		[TestMethod]
		public void GetGame2221BoxscoreAndPlayByPlayTest()
		{
			var client = GetClient();

			var game = client.GetGame(2015, 2221, true, true);

			Assert.IsNotNull(game.Boxscore);
			Assert.IsNotNull(game.PlayByPlay);
		}

	}
}
