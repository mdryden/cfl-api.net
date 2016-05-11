﻿using System;
using System.Configuration;
using mdryden.cflapi.v1.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using mdryden.cflapi.v1.Client.Players;

namespace mdryden.cflapi.v1.ClientTests.Players
{
	[TestClass]
	public class PlayersClientTests : ClientTestsBase
	{

		private PlayersClient GetClient()
		{
			return new PlayersClient(GetApiKey());
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