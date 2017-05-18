﻿using System;
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
	public class GameFilterGreaterOrEqualToThanTests : ClientTestsBase
	{

		private GamesClient GetClient()
		{
			return new GamesClient(GetApiKey());
		}

		[TestMethod]
		public void FilterByDateStartTest()
		{
			var client = GetClient();

			var filterValue = DateTime.SpecifyKind(new DateTime(2015, 06, 08, 23, 30, 00), DateTimeKind.Utc);

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.DateStart.GreaterThanOrEqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().DateStart >= filterValue && games.Last().DateStart >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterBySeasonTest()
		{
			var client = GetClient();

			var filterValue = 2014;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Season.GreaterThanOrEqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Season >= filterValue && games.Last().Season >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByWeekTest()
		{
			var client = GetClient();

			var filterValue = 5;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Week.GreaterThanOrEqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Week >= filterValue && games.Last().Week >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTemperatureTest()
		{
			var client = GetClient();

			var filterValue = 21;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Temperature.GreaterThanOrEqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Weather.Temperature >= filterValue && games.Last().Weather.Temperature >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByAttendanceTest()
		{
			var client = GetClient();

			var filterValue = 27279;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Attendance.GreaterThanOrEqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = games.First().Attendance >= filterValue && games.Last().Attendance >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTeam1Test()
		{
			var client = GetClient();

			var filterValue = TeamAbbreviations.Saskatchewan;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Team1.GreaterThanOrEqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = string.Compare(games.First().Team1.Abbreviation, filterValue) >= 0 && string.Compare(games.Last().Team1.Abbreviation, filterValue) >= 0;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);

		}

		[TestMethod]
		public void FilterByTeam2Test()
		{
			var client = GetClient();

			var filterValue = TeamAbbreviations.Edmonton;

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Team2.GreaterThanOrEqualTo(filterValue) } };

			var games = client.GetGames(options: options);

			var expected = true;
			var actual = string.Compare(games.First().Team2.Abbreviation, filterValue) >= 0 && string.Compare(games.Last().Team2.Abbreviation, filterValue) >= 0;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}
		

		[TestMethod]
		public void FilterByEventTypeAllPlayoffsTest()
		{
			var client = GetClient();

			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.EventTypeId.GreaterThanOrEqualTo(EventTypeIds.Playoffs) } };

			var games = client.GetGames(season: 2015, options: options);

			var expected = 5;
			var actual = games.Where(g => g.EventType.EventTypeId == EventTypeIds.GreyCup || g.EventType.EventTypeId == EventTypeIds.Playoffs).Count();

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

	}
}
