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

			var games = client.GetGames(1, 20);

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

		[TestMethod]
		public void GetFirst20PlayersTest()
		{
			var client = GetClient();

			var players = client.GetPlayers(1, 20);

			var expected = 20;
			var actual = players.Count();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetNext20PlayersTest()
		{
			var client = GetClient();

			var players = client.GetPlayers(2, 20);

			var expected = 20;
			var actual = players.Count();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetHenryBurrisTest()
		{
			var client = GetClient();

			var player = client.GetPlayer(15850, false, false);

			var expected = 15850;
			var actual = player.CflCentralId;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetHenryBurrisSeasonsTest()
		{
			var client = GetClient();

			var player = client.GetPlayer(15850, true, false);

			Assert.IsNotNull(player.Seasons);
		}
		
		[TestMethod]
		public void GetHenryBurrisGameByGameTest()
		{
			var client = GetClient();

			var player = client.GetPlayer(15850, false, true);

			Assert.IsNotNull(player.GameByGame);
		}

		[TestMethod]
		public void GetHenryBurrisSeasonsAndGameByGameTest()
		{
			var client = GetClient();

			var player = client.GetPlayer(15850, true, true);

			Assert.IsNotNull(player.Seasons);
			Assert.IsNotNull(player.GameByGame);
		}

	}
}
