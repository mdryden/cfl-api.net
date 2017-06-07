using System;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using mdryden.cflapi.v1.Client.Standings;
using System.Configuration;
using mdryden.cflapi.v1.Models.Standings;

namespace mdryden.cflapi.v1.Tests.Models.Standings
{
	[TestClass]
	public class StandingsTests : DeserializationTestsBase
	{
		

		[TestMethod]
		public void StandingsTest()
		{
			var client = new StandingsClient(GetApiKey());

			client.GetStandings(2015);

			TryDeserialize<DataContainer<SeasonContainer>>(client.LastResponse);
		}

		[TestMethod]
		public void CrossoverStandingsTest()
		{
			var client = new StandingsClient(GetApiKey());

			client.GetCrossoverStandings(2015);

			TryDeserialize<DataContainer<CrossoverContainer>>(client.LastResponse);
		}
	}
}
