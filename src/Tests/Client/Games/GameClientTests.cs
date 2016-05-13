using System;
using System.Configuration;
using mdryden.cflapi.v1.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using mdryden.cflapi.v1.Client.Games;

namespace mdryden.cflapi.v1.Tests.Client.Games
{
	[TestClass]
	public class GameClientTests : ClientTestsBase
	{

		private GamesClient GetClient()
		{
			return new GamesClient(GetApiKey());
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
		


	}
}
