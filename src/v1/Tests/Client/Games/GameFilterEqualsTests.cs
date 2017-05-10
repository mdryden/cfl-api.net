using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Games;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.Tests.Client.Games
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

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.DateStart.EqualTo(filterValue) } };
			
			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().DateStart == filterValue && games.Last().DateStart == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterBySeasonTest()
		{
			var client = GetClient();

			var filterValue = 2014;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Season.EqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Season == filterValue && games.Last().Season == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByWeekTest()
		{
			var client = GetClient();

			var filterValue = 5;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Week.EqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Week == filterValue && games.Last().Week == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[Ignore] // filtering by temp eq is broken http://api.cfl.ca/v1/games/2015?filter[temperature][eq]=21
		[TestMethod]
		public void FilterByTemperatureTest()
		{
			var client = GetClient();

			var filterValue = 21;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Temperature.EqualTo(filterValue) } };

			var games = client.GetGames(season: 2015, options: options);
			var firstGame = games.FirstOrDefault();
			var lastGame = games.LastOrDefault();

			Assert.IsNotNull(firstGame, client.LastRequestUrl);
			Assert.IsNotNull(lastGame, client.LastRequestUrl);

			var expected = true;
			var actual = games.First().Weather.Temperature == filterValue && games.Last().Weather.Temperature == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByAttendanceTest()
		{
			var client = GetClient();

			var filterValue = 27279;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Attendance.EqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Attendance == filterValue && games.Last().Attendance == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTeam1Test()
		{
			var client = GetClient();

			var filterValue = TeamAbbreviations.Saskatchewan;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Team1.EqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Team1.Abbreviation == filterValue && games.Last().Team1.Abbreviation == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTeam2Test()
		{
			var client = GetClient();

			var filterValue = TeamAbbreviations.Winnipeg;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Team2.EqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Team2.Abbreviation == filterValue && games.Last().Team2.Abbreviation == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}



	}
}
