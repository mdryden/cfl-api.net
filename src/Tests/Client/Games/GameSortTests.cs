using System;
using System.Configuration;
using mdryden.cflapi.v1.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using mdryden.cflapi.v1.Client.Games;

namespace mdryden.cflapi.v1.Tests.Client.Games
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
		public void SortByDateTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.DateStart, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(options: descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.DateStart, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(options: ascendingOptions);

			var highest = gamesDescending.First().DateStart;
			var lowest = gamesAscending.First().DateStart;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SortBySeasonTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Season, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(options: descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Season, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(options: ascendingOptions);

			var highest = gamesDescending.First().Season;
			var lowest = gamesAscending.First().Season;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SortByWeekTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Week, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(options: descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Week, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(options: ascendingOptions);

			var highest = gamesDescending.First().Week;
			var lowest = gamesAscending.First().Week;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SortByTemperatureTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Temperature, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(options: descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Temperature, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(options: ascendingOptions);

			var highest = gamesDescending.First().Weather.Temperature;
			var lowest = gamesAscending.First().Weather.Temperature;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SortByAttendanceTest()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Attendance, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(options: descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Attendance, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(options: ascendingOptions);

			var highest = gamesDescending.First().Attendance;
			var lowest = gamesAscending.First().Attendance;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SortByTeam1Test()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Team1, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(options: descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Team1, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(options: ascendingOptions);

			var highest = gamesDescending.First().Team1.TeamId;
			var lowest = gamesAscending.First().Team1.TeamId;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SortByTeam2Test()
		{
			var client = GetClient();

			var descendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Team2, SortOrder.Descending) } };
			var gamesDescending = client.GetGames(options: descendingOptions);

			var ascendingOptions = new GamesRequestOptions { Sorts = new[] { new GameSort(GameSortTypes.Team2, SortOrder.Ascending) } };
			var gamesAscending = client.GetGames(options: ascendingOptions);

			var highest = gamesDescending.First().Team2.TeamId;
			var lowest = gamesAscending.First().Team2.TeamId;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}


	}
}
