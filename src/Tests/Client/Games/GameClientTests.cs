using System;
using System.Configuration;
using mdryden.cflapi.v1.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using mdryden.cflapi.v1.Client.Games;
using mdryden.cflapi.v1.Models.Games;
using System.Collections;
using System.Collections.Generic;

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
		
		[TestMethod]
		public void ManualIdsTest()
		{
			var client = GetClient();

			var gameId = 2221;

			var game = client.GetGame(2015, gameId, true, true);

			Assert.AreEqual(gameId, game.Team1.GameId);
			Assert.AreEqual(gameId, game.Team2.GameId);
			
			Assert.AreEqual(gameId, game.Boxscore.GameId);
			Assert.AreEqual(gameId, game.Boxscore.Teams.GameId);

			BoxscoreTeamAsserts(gameId, game.Boxscore.Teams.Team1);
			BoxscoreTeamAsserts(gameId, game.Boxscore.Teams.Team2);

		}

		private void BoxscoreTeamAsserts(int gameId, BoxscoreTeam team)
		{
			Assert.AreEqual(gameId, team.GameId);
			Assert.AreEqual(gameId, team.Defence.GameId);
			//Assert.AreEqual(gameId, team.FieldGoalReturns.GameId);
			Assert.AreEqual(gameId, team.Kicking.GameId);
			Assert.AreEqual(gameId, team.KickReturns.GameId);
			Assert.AreEqual(gameId, team.Passing.GameId);
			Assert.AreEqual(gameId, team.PuntReturns.GameId);
			Assert.AreEqual(gameId, team.Punts.GameId);
			Assert.AreEqual(gameId, team.Receiving.GameId);
			Assert.AreEqual(gameId, team.Rushing.GameId);
		}

		private void BoxscorePlayersAsserts(int gameId, BoxscorePlayers players)
		{
			Assert.AreEqual(gameId, players.GameId);
			BoxscorePlayerCollectionAsserts(gameId, players.Defence);
			BoxscorePlayerCollectionAsserts(gameId, players.FieldGoalReturns);
			BoxscorePlayerCollectionAsserts(gameId, players.Kicking);
			BoxscorePlayerCollectionAsserts(gameId, players.KickReturns);
			BoxscorePlayerCollectionAsserts(gameId, players.Passing);
			BoxscorePlayerCollectionAsserts(gameId, players.PuntReturns);
			BoxscorePlayerCollectionAsserts(gameId, players.Punts);
			BoxscorePlayerCollectionAsserts(gameId, players.Receiving);
			BoxscorePlayerCollectionAsserts(gameId, players.Rushing);
		}

		private void BoxscorePlayerCollectionAsserts(int gameId, IEnumerable<object> collection)
		{
			if (collection != null && collection.Count() > 0)
			{
				var type = collection.First().GetType();
				var property = type.GetProperty("GameId");

				foreach (var item in collection)
				{
					var value = property.GetValue(item, null);
					Assert.AreEqual(gameId, value);
				}
			}
		}


	}
}
