using System;
using System.Configuration;
using mdryden.cflapi.v1.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using mdryden.cflapi.v1.Client.Players;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Tests.Client.Players
{
	[TestClass]
	public class PlayerClientTests : ClientTestsBase
	{

		private PlayersClient GetClient()
		{
			return new PlayersClient(GetApiKey());
		}
		
		private void PlayerObjectCollectionAsserts(int playerId, IEnumerable<object> collection)
		{
			if (collection != null && collection.Count() > 0)
			{
				var type = collection.First().GetType();
				var property = type.GetProperty("PlayerId");

				foreach (var item in collection)
				{
					var value = property.GetValue(item, null);
					Assert.AreEqual(playerId, value);
				}
			}
		}

		[TestMethod]
		public void GetFirst20PlayersTest()
		{
			var client = GetClient();

			var players = client.GetPlayers(1, 20);

			var expected = 20;
			var actual = players.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetNext20PlayersTest()
		{
			var client = GetClient();

			var players = client.GetPlayers(2, 20);

			var expected = 20;
			var actual = players.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void GetHenryBurrisTest()
		{
			var client = GetClient();

			var player = client.GetPlayer(15850, false, false);

			var expected = 15850;
			var actual = player.CflCentralId;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
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


		[TestMethod]
		public void GetChadOwensSeasonsAndGameByGameTest()
		{
			var client = GetClient();

			var player = client.GetPlayer(115154, true, true);

			Assert.IsNotNull(player.Seasons);
			Assert.IsNotNull(player.GameByGame);
			Assert.IsNotNull(player.Seasons.KickoffReturns);
			Assert.IsNotNull(player.Seasons.MissedFieldGoalReturns);
			Assert.IsNotNull(player.Seasons.PuntReturns);
			Assert.IsNotNull(player.GameByGame.KickoffReturns);
			Assert.IsNotNull(player.GameByGame.MissedFieldGoalReturns);
			Assert.IsNotNull(player.GameByGame.PuntReturns);
		}

		[TestMethod]
		public void HandleEmptyPayloadTest()
		{
			var client = GetClient();

			// make sure the api is working
			var pageNumber = 133;
			var players = client.GetPlayers(pageNumber, 20);

			while (true)
			{
				pageNumber++;
				players = client.GetPlayers(pageNumber, 20);

				if (players.Count() == 0)
				{
					break;
				}
			}

			Assert.IsTrue(true);
		}

		[TestMethod]
		public void ManualIdsTest()
		{
			var client = GetClient();

			var playerId = 15850;

			var player = client.GetPlayer(playerId, true, true);

			Assert.AreEqual(playerId, player.GameByGame.PlayerId);
			PlayerObjectCollectionAsserts(playerId, player.GameByGame.Defence);
			PlayerObjectCollectionAsserts(playerId, player.GameByGame.FieldGoals);
			PlayerObjectCollectionAsserts(playerId, player.GameByGame.Passing);
			PlayerObjectCollectionAsserts(playerId, player.GameByGame.Punts);
			PlayerObjectCollectionAsserts(playerId, player.GameByGame.Receiving);
			PlayerObjectCollectionAsserts(playerId, player.GameByGame.Rushing);

			Assert.AreEqual(playerId, player.Seasons.PlayerId);
			PlayerObjectCollectionAsserts(playerId, player.Seasons.Defence);
			PlayerObjectCollectionAsserts(playerId, player.Seasons.FieldGoals);
			PlayerObjectCollectionAsserts(playerId, player.Seasons.Passing);
			PlayerObjectCollectionAsserts(playerId, player.Seasons.Punts);
			PlayerObjectCollectionAsserts(playerId, player.Seasons.Receiving);
			PlayerObjectCollectionAsserts(playerId, player.Seasons.Rushing);
		}
		[TestMethod]
		public void GetHenryBurrisStatsIncIdTest()
		{
			var client = GetClient();

			var player = client.GetPlayer(15850, false, false);

			var expected = 25875;
			var actual = player.StatsIncId;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

	}
}
