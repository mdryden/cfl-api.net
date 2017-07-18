using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mdryden.cflapi.v1.Models.Games;

namespace mdryden.cflapi.v1.Tests.Client.Games
{
	[TestClass]
	public class GameFilterEqualsTests : ClientTestsBase
	{
		

		[Ignore] // filtering by date does not appear to work, reported as issue #1
		[TestMethod]
		public void FilterByDateStartTest()
		{			
			var filterValue = new DateTime(2016, 6, 23);

			var games = Endpoint.Games.GetGames().WithFilter().DateStart(GamesFilterOperators.EqualTo, filterValue).Invoke();

			var expected = true;
			var actual = games.FirstOrDefault()?.DateStart == filterValue && games.LastOrDefault()?.DateStart == filterValue;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterBySeasonTest()
		{
			var filterValue = 2014;
			
			var games = Endpoint.Games.GetGames().WithFilter().Season(GamesFilterOperators.EqualTo, filterValue).Invoke();

			var expected = true;
			var actual = games.First().Season == filterValue && games.Last().Season == filterValue;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByWeekTest()
		{
			var filterValue = 5;
			
			var games = Endpoint.Games.GetGames().WithFilter().Week(GamesFilterOperators.EqualTo, filterValue).Invoke();

			var expected = true;
			var actual = games.First().Week == filterValue && games.Last().Week == filterValue;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[Ignore] // filtering by temp eq is broken.  Reported as issue #2
		[TestMethod]
		public void FilterByTemperatureTest()
		{
			var filterValue = 21;
			
			var games = Endpoint.Games.GetGames().Season(2015).WithFilter().Temperature(GamesFilterOperators.EqualTo, filterValue).Invoke();
			var firstGame = games.FirstOrDefault();
			var lastGame = games.LastOrDefault();

			Assert.IsNotNull(firstGame, Endpoint.RequestClient.LastRequestUrl);
			Assert.IsNotNull(lastGame, Endpoint.RequestClient.LastRequestUrl);

			var expected = true;
			var actual = games.First().Weather.Temperature == filterValue && games.Last().Weather.Temperature == filterValue;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByAttendanceTest()
		{
			var filterValue = 27279;
			
			var games = Endpoint.Games.GetGames().WithFilter().Attendance(GamesFilterOperators.EqualTo, filterValue).Invoke();

			var expected = true;
			var actual = games.First().Attendance == filterValue && games.Last().Attendance == filterValue;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTeam1Test()
		{
			var filterValue = TeamAbbreviations.Saskatchewan;

			var games = Endpoint.Games.GetGames().WithFilter().Team1(GamesFilterOperators.EqualTo, filterValue).Invoke();

			var expected = true;
			var actual = games.First().Team1.Abbreviation == filterValue && games.Last().Team1.Abbreviation == filterValue;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTeam2Test()
		{
			var filterValue = TeamAbbreviations.Winnipeg;
			
			var games = Endpoint.Games.GetGames().WithFilter().Team2(GamesFilterOperators.EqualTo, filterValue).Invoke();

			var expected = true;
			var actual = games.First().Team2.Abbreviation == filterValue && games.Last().Team2.Abbreviation == filterValue;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByEventTypeGreyCupTest()
		{
			var filterValue = EventTypeIds.GreyCup;
			
			var games = Endpoint.Games.GetGames().Season(2015).WithFilter().EventTypeId(GamesFilterOperators.EqualTo, filterValue).Invoke();

			var expected = filterValue;
			var actual = games.First()?.EventType?.EventTypeId;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void FilterPlayByPlayGame2267Play120Test()
		{
			throw new NotImplementedException();
			//var filterValue = 110;

			//var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.PlayByPlaySequence.EqualTo(filterValue) } };

			//var game = Endpoint.Games.GetGame(2016, 2267).WithPlayByPlay(), includePlayByPlay: true, options: options);

			//var expected = filterValue;
			//var actual = game.PlayByPlay?.FirstOrDefault()?.PlaySequence;

			//Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}
	}
}
