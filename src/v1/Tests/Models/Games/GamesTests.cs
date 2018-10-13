using System;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using System.Collections.Generic;
using mdryden.cflapi.v1.Client;

namespace mdryden.cflapi.v1.Tests.Models.Games
{
	[TestClass]
	public class GamesTests : DeserializationTestsBase
	{
		
		[TestMethod]
		public void FullGameTest()
		{			
			var game = Endpoint.Games.GetGame(2015, 2266)
				.WithBoxscore()
				.WithRosters()
				.WithPlayByPlay()
				.WithPenalties()
				.Invoke();

			Assert.IsNotNull(game);
		}

		[TestMethod]
		public void ListOfGamesTest()
		{
			var games = Endpoint.Games.GetGames().Season(2015).Invoke();

			Assert.IsNotNull(games);
		}
	}
}
