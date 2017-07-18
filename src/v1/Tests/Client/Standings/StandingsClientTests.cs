using mdryden.cflapi.v1.Client.Standings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Tests.Client.Standings
{
	[TestClass]
	public class StandingsClientTests : ClientTestsBase
	{

		private StandingsClient GetClient()
		{
			return new StandingsClient(GetApiKey());
		}

		[TestMethod]
		public void Get2015StandingsTest()
		{
			var client = GetClient();

			var expected = 2015;

			var standings = client.GetStandings(expected);

			Assert.IsNotNull(standings.East?.Standings, Endpoint.RequestClient.LastRequestUrl);

			var actual = standings.East.Standings[0].Season;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Get2016CrossoverTest()
		{
			var client = GetClient();

			var expected = 2016;

			var standings = client.GetStandings(expected);

			Assert.IsNotNull(standings.East?.Standings, Endpoint.RequestClient.LastRequestUrl);

			var actual = standings.East.Standings[0].Season;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Check2016CrossoverTest()
		{
			var client = GetClient();

			var season = 2016;

			var standings = client.GetCrossoverStandings(season);

			Assert.IsNotNull(standings.Crossover?.Standings, Endpoint.RequestClient.LastRequestUrl);

			var expected = "Edmonton";
			var actual = standings.Crossover.Standings[0].Location;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Check2016EliminatedTest()
		{
			var client = GetClient();

			var season = 2016;

			var standings = client.GetCrossoverStandings(season);

			Assert.IsNotNull(standings.OutOfPlayoffs?.Standings, Endpoint.RequestClient.LastRequestUrl);

			var expected = 3;
			var actual = standings.OutOfPlayoffs.Standings.Count();

			Assert.AreEqual(expected, actual);
		}

	}
}
