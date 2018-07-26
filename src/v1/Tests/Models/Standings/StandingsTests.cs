using System;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using mdryden.cflapi.v1.Models.Standings;
using mdryden.cflapi.v1.Client;

namespace mdryden.cflapi.v1.Tests.Models.Standings
{
	[TestClass]
	public class StandingsTests : DeserializationTestsBase
	{
		

		[TestMethod]
		public void StandingsTest()
		{
			SeasonStandings standings = Endpoint.Standings.GetStandings(2015).Invoke();

			Assert.IsNotNull(standings);
		}

		[TestMethod]
		public void CrossoverStandingsTest()
		{
			CrossoverStandings standings = Endpoint.Standings.GetCrossoverStandings(2015).Invoke();

			Assert.IsNotNull(standings);

		}
	}
}
