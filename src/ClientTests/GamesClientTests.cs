using System;
using System.Configuration;
using mdryden.cflapi.v1.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using mdryden.cflapi.v1.Client.Games;

namespace mdryden.cflapi.v1.ClientTests
{
	[TestClass]
	public class GamesClientTests
	{

		private GamesClient GetClient()
		{
			var apiKey = ConfigurationManager.AppSettings["apiKey"];

			return new GamesClient(apiKey);
		}

		[TestMethod]
		public void GetFirst20GamesTest()
		{
			var client = GetClient();

			var games = client.GetGames(1, 20);

			var expected = 20;
			var actual = games.Count();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetNext20GamesTest()
		{
			var client = GetClient();

			var games = client.GetGames(2, 20);

			var expected = 40;
			var actual = games.Last().GameNumber;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetGame2221Test()
		{
			var client = GetClient();

			var game = client.GetGame(2015, 2221, false, false);

			var expected = 2221;
			var actual = game.GameId;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetGame2221BoxscoreTest()
		{
			var client = GetClient();

			var game = client.GetGame(2015, 2221, true, false);

			Assert.IsNotNull(game.Boxscore);
		}

		[TestMethod]
		public void GetGame2221PlayByPlayTest()
		{
			var client = GetClient();

			var game = client.GetGame(2015, 2221, false, true);

			Assert.IsNotNull(game.PlayByPlay);
		}

		[TestMethod]
		public void GetGame2221BoxscoreAndPlayByPlayTest()
		{
			var client = GetClient();

			var game = client.GetGame(2015, 2221, true, true);

			Assert.IsNotNull(game.Boxscore);
			Assert.IsNotNull(game.PlayByPlay);
		}

		[TestMethod]
		public void SortByDateTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.DateStart, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(1, 20, descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.DateStart, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(1, 20, ascendingOptions);

			var highest = gamesDescending.First().DateStart;
			var lowest = gamesAscending.First().DateStart;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortBySeasonTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Season, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(1, 20, descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Season, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(1, 20, ascendingOptions);

			var highest = gamesDescending.First().Season;
			var lowest = gamesAscending.First().Season;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByWeekTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Week, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(1, 20, descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Week, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(1, 20, ascendingOptions);

			var highest = gamesDescending.First().Week;
			var lowest = gamesAscending.First().Week;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByTemperatureTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Temperature, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(1, 20, descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Temperature, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(1, 20, ascendingOptions);

			var highest = gamesDescending.First().Weather.Temperature;
			var lowest = gamesAscending.First().Weather.Temperature;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByAttendanceTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Attendance, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(1, 20, descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Attendance, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(1, 20, ascendingOptions);

			var highest = gamesDescending.First().Attendance;
			var lowest = gamesAscending.First().Attendance;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByTeam1Test()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Team1, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(1, 20, descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Team1, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(1, 20, ascendingOptions);

			var highest = gamesDescending.First().Team1.TeamId;
			var lowest = gamesAscending.First().Team1.TeamId;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByTeam2Test()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Team2, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(1, 20, descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Team2, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(1, 20, ascendingOptions);

			var highest = gamesDescending.First().Team2.TeamId;
			var lowest = gamesAscending.First().Team2.TeamId;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}


	}
}
