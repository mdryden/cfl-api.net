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
	public class GameFilterInTests : ClientTestsBase
	{

		private GamesClient GetClient()
		{
			return new GamesClient(GetApiKey());
		}

		[Ignore] // Issue #3
		[TestMethod]
		public void FilterByDateStartTest()
		{
			var client = GetClient();

			var date1 = new DateTime(2015, 06, 23);
			var date2 = new DateTime(2015, 06, 24);

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.DateStart.In(date1, date2) } };

			var games = client.GetGames(options: options);

			var expected = 2;
			var actual = games.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterBySeasonTest()
		{
			var client = GetClient();

			var season1 = 2014;
			var season2 = 2015;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Season.In(season1, season2), FluentGamesFilterFactory.EventTypeId.EqualTo(EventTypeIds.GreyCup) } };

			var games = client.GetGames(options: options);

			var expected = 2;
			var actual = games.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void WeekInTest()
		{
			var client = GetClient();

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Week.In(2, 9) } };

			var games = client.GetGames(options: options);

			var week2 = games.FirstOrDefault(g => g.Week == 2);
			var week9 = games.FirstOrDefault(g => g.Week == 9);

			Assert.IsNotNull(week2, Endpoint.RequestClient.LastRequestUrl);
			Assert.IsNotNull(week9, Endpoint.RequestClient.LastRequestUrl);

		}

		[Ignore]
		[TestMethod]
		public void FilterByTemperatureTest()
		{
			var client = GetClient();

			var temp1 = 21;
			var temp2 = 24;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Temperature.In(temp1, temp2) } };

			var games = client.GetGames(options: options);

			var expected = 2;
			var actual = games.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByAttendanceTest()
		{
			var client = GetClient();

			var value1 = 27279;
			var value2 = 19452;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Attendance.In(value1, value2) } };

			var games = client.GetGames(options: options);

			var expected = 2;
			var actual = games.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTeam1Test()
		{
			var client = GetClient();

			var team1 = TeamAbbreviations.Saskatchewan;
			var team2 = TeamAbbreviations.Winnipeg;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Team1.In(team1, team2), FluentGamesFilterFactory.EventTypeId.EqualTo(EventTypeIds.Preseason) } };

			var games = client.GetGames(season: 2015, options: options);

			var expected = 2;
			var actual = games.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTeam2Test()
		{
			var client = GetClient();

			var team1 = TeamAbbreviations.Saskatchewan;
			var team2 = TeamAbbreviations.Winnipeg;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.Team2.In(team1, team2), FluentGamesFilterFactory.EventTypeId.EqualTo(EventTypeIds.Preseason) } };

			var games = client.GetGames(season: 2015, options: options);

			var expected = 2;
			var actual = games.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

		[Ignore] // Issue #5
		[TestMethod]
		public void FilterByEventTypeTest()
		{
			var client = GetClient();

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.EventTypeId.In(EventTypeIds.Playoffs, EventTypeIds.GreyCup) } };

			var games = client.GetGames(season: 2015, options: options);

			var expected = 5;
			var actual = games.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void FilterPlayByPlayTest()
		{
			var client = GetClient();

			var expected1 = 10;
			var expected2 = 50;

			var options = new GamesRequestOptions { Filters = new[] { FluentGamesFilterFactory.PlayByPlaySequence.In(expected1, expected2) } };

			var game = client.GetGame(2016, 2267, includePlayByPlay: true, options: options);

			var play1 = game.PlayByPlay?.FirstOrDefault(p => p.PlaySequence == expected1);
			Assert.IsNotNull(play1, Endpoint.RequestClient.LastRequestUrl);

			var play2 = game.PlayByPlay?.FirstOrDefault(p => p.PlaySequence == expected2);
			Assert.IsNotNull(play2, Endpoint.RequestClient.LastRequestUrl);
		}
		



	}
}
