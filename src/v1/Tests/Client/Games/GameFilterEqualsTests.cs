using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Games;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mdryden.cflapi.v1.Models.Games;

namespace mdryden.cflapi.v1.Tests.Client.Games
{
	[TestClass]
	public class GameFilterEqualsTests : ClientTestsBase
	{

		private GamesClient GetClient()
		{
			return new GamesClient(GetApiKey());
		}

		[Ignore] // filtering by date does not appear to work, reported as issue #1
		[TestMethod]
		public void FilterByDateStartTest()
		{
			var client = GetClient();
			
			var filterValue = new DateTime(2016, 6, 23);

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.DateStart.EqualTo(filterValue) } };
			
			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.FirstOrDefault()?.DateStart == filterValue && games.LastOrDefault()?.DateStart == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterBySeasonTest()
		{
			var client = GetClient();

			var filterValue = 2014;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Season.EqualTo(filterValue) } };

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

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Week.EqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Week == filterValue && games.Last().Week == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[Ignore] // filtering by temp eq is broken.  Reported as issue #2
		[TestMethod]
		public void FilterByTemperatureTest()
		{
			var client = GetClient();

			var filterValue = 21;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Temperature.EqualTo(filterValue) } };

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

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Attendance.EqualTo(filterValue) } };

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

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Team1.EqualTo(filterValue) } };

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

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Team2.EqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Team2.Abbreviation == filterValue && games.Last().Team2.Abbreviation == filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByEventTypeGreyCupTest()
		{
			var client = GetClient();

			var filterValue = EventTypeIds.GreyCup;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.EventTypeId.EqualTo(filterValue) } };

			var games = client.GetGames(season: 2015, options: options);

			var expected = filterValue;
			var actual = games.First()?.EventType?.EventTypeId;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void FilterPlayByPlayGame2267Play120Test()
		{
			var client = GetClient();

			var filterValue = 110;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.PlayByPlaySequence.EqualTo(filterValue) } };

			var game = client.GetGame(2016, 2267, includePlayByPlay: true, options: options);

			var expected = filterValue;
			var actual = game.PlayByPlay?.FirstOrDefault()?.PlaySequence;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}
	}
}
