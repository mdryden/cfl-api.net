using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Games;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.ClientTests.Games
{
	[TestClass]
	public class GameFilterEqualsTests : ClientTestsBase
	{

		private GamesClient GetClient()
		{
			return new GamesClient(GetApiKey());
		}

		[Ignore] // filtering by date does not appear to work, I get no results here for "http://api.cfl.ca/v1/games?key=12345&filter[date_start][eq]=2015-06-08T19:30:00-04:00&page[number]=1&page[size]=20"
		[TestMethod]
		public void FilterByDateStartTest()
		{
			var client = GetClient();

			var filterValue = DateTime.SpecifyKind(new DateTime(2015, 06, 08, 23, 30, 00), DateTimeKind.Utc);

			var options = new GamesRequestOptions { Filters = new[] { GameFilter.DateStart(FilterOperators.EqualTo, filterValue) } };

			var games = client.GetGames(1, 20, options);

			var expected = true;
			var actual = games.First().DateStart == filterValue && games.Last().DateStart == filterValue;

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void FilterBySeasonTest()
		{
			var client = GetClient();

			var filterValue = 2014;

			var options = new GamesRequestOptions { Filters = new[] { GameFilter.Season(FilterOperators.EqualTo, filterValue) } };

			var games = client.GetGames(1, 20, options);

			var expected = true;
			var actual = games.First().Season == filterValue && games.Last().Season == filterValue;

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void FilterByWeekTest()
		{
			var client = GetClient();

			var filterValue = 5;

			var options = new GamesRequestOptions { Filters = new[] { GameFilter.Week(FilterOperators.EqualTo, filterValue) } };

			var games = client.GetGames(1, 20, options);

			var expected = true;
			var actual = games.First().Week == filterValue && games.Last().Week == filterValue;

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void FilterByTemperatureTest()
		{
			var client = GetClient();

			var filterValue = 21;

			var options = new GamesRequestOptions { Filters = new[] { GameFilter.Temperature(FilterOperators.EqualTo, filterValue) } };

			var games = client.GetGames(1, 20, options);

			var expected = true;
			var actual = games.First().Weather.Temperature == filterValue && games.Last().Weather.Temperature == filterValue;

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void FilterByAttendanceTest()
		{
			var client = GetClient();

			var filterValue = 27279;

			var options = new GamesRequestOptions { Filters = new[] { GameFilter.Attendance(FilterOperators.EqualTo, filterValue) } };

			var games = client.GetGames(1, 20, options);

			var expected = true;
			var actual = games.First().Attendance == filterValue && games.Last().Attendance == filterValue;

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void FilterByTeam1Test()
		{
			var client = GetClient();

			var filterValue = TeamAbbreviations.Saskatchewan;

			var options = new GamesRequestOptions { Filters = new[] { GameFilter.Team1(FilterOperators.EqualTo, filterValue) } };

			var games = client.GetGames(1, 20, options);

			var expected = true;
			var actual = games.First().Team1.Abbreviation == filterValue && games.Last().Team1.Abbreviation == filterValue;

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void FilterByTeam2Test()
		{
			var client = GetClient();

			var filterValue = TeamAbbreviations.Winnipeg;

			var options = new GamesRequestOptions { Filters = new[] { GameFilter.Team2(FilterOperators.EqualTo, filterValue) } };

			var games = client.GetGames(1, 20, options);

			var expected = true;
			var actual = games.First().Team2.Abbreviation == filterValue && games.Last().Team2.Abbreviation == filterValue;

			Assert.AreEqual(expected, actual);

		}



	}
}
