using System;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using mdryden.cflapi.v1.Client.Standings;
using System.Configuration;
using mdryden.cflapi.v1.Client.Games;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Tests.Models.Games
{
	[TestClass]
	public class GamesTests : DeserializationTestsBase
	{
		
		[TestMethod]
		public void FullGameTest()
		{
			var client = new GamesClient(GetApiKey());
			client.GetGame(2015, 2266, true, true, true);

			TryDeserialize<DataArrayContainer<Game>>(client.LastResponse);
		}

		[TestMethod]
		public void ListOfGamesTest()
		{
			var client = new GamesClient(GetApiKey());
			client.GetGames(season: 2015);

			TryDeserialize<DataArrayContainer<Game>>(client.LastResponse);
		}
	}
}
