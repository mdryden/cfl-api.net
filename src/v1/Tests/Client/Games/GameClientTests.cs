using System;
using System.Configuration;
using mdryden.cflapi.v1.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using mdryden.cflapi.v1.Models.Games;
using System.Collections;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Tests.Client.Games
{
	[TestClass]
	public class GameClientTests : ClientTestsBase
	{
		
		[TestMethod]
		[Ignore]
		public void RateLimitTest()
		{
			var start = DateTime.Now;
			var expected = 60;
			var actual = 0;

			for (var x = 1; x <= expected; x++)
			{
				var games = Endpoint.Games.GetGames().PageNumber(x).PageSize(1).Invoke();
				actual++;

			}
			var end = DateTime.Now;
			var duration = start - end;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetFirst20GamesTest()
		{
			var games = Endpoint.Games.GetGames().PageNumber(1).PageSize(20).Invoke();

			var expected = 20;
			var actual = games.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetNext20GamesTest()
		{
			var games = Endpoint.Games.GetGames().PageNumber(2).PageSize(20).Invoke();

			var expected = 40;
			var actual = games.Last().GameNumber;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetGame2221Test()
		{
			var game = Endpoint.Games.GetGame(2015, 2221).Invoke();

			var expected = 2221;
			var actual = game.GameId;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetGame2221BoxscoreTest()
		{
			var game = Endpoint.Games.GetGame(2015, 2221).WithBoxscore().Invoke();

			Assert.IsNotNull(game.Boxscore);
		}

		[TestMethod]
		public void GetGame2221PlayByPlayTest()
		{
			var game = Endpoint.Games.GetGame(2015, 2221).WithPlayByPlay().Invoke();

			Assert.IsNotNull(game.PlayByPlay);
		}

		[TestMethod]
		public void GetGame2221RostersTest()
		{
			var game = Endpoint.Games.GetGame(2015, 2221).WithRosters().Invoke();

			Assert.IsNotNull(game.Rosters);
		}

		[TestMethod]
		public void GetGame2221AllDataTest()
		{
			var game = Endpoint.Games.GetGame(2015, 2221).WithBoxscore().WithPlayByPlay().WithRosters().Invoke();

			Assert.IsNotNull(game.Boxscore);
			Assert.IsNotNull(game.PlayByPlay);
		}

		[TestMethod]
		public void ManualIdsTest()
		{
			var gameId = 2221;

			var game = Endpoint.Games.GetGame(2015, gameId).WithBoxscore().WithPlayByPlay().WithRosters().Invoke();

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

		[TestMethod]
		public void TestGame2267()
		{
			var game = Endpoint.Games.GetGame(2016, 2267).WithBoxscore().WithPlayByPlay().WithRosters().Invoke();
		}

		[TestMethod]
		public void GetGame2221DefensiveTouchdownsTest()
		{
			var game = Endpoint.Games.GetGame(2015, 2221).WithBoxscore().Invoke();

			var expected = 1;
			var actual = game.Boxscore.Teams.Team1.Defence.DefensiveTouchdowns;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetGame2225DefensiveSafetiesTest()
		{
			var game = Endpoint.Games.GetGame(2015, 2225).WithBoxscore().Invoke();

			var expected = 1;
			var actual = game.Boxscore.Teams.Team1.Defence.DefensiveSafeties;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetGame2361EventTitleTest()
		{
			var game = Endpoint.Games.GetGame(2016, 2361).Invoke();

			var expected = "104th Grey Cup";
			var actual = game.EventType.Title;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetGame2361Team1YACTest()
		{
			var game = Endpoint.Games.GetGame(2016, 2361).WithBoxscore().Invoke();

			var expected = 163;
			var actual = game.Boxscore.Teams.Team1.Receiving.ReceiveYardsAfterCatch;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}
	}
}
