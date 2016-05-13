using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.Tests.Client.Players
{
	[TestClass]
	public class PlayerSortTests : ClientTestsBase
	{

		private PlayersClient GetClient()
		{
			return new PlayersClient(GetApiKey());
		}

		[TestMethod]
		public void SortByCflCentralIdTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.CflCentralId, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.CflCentralId, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().CflCentralId;
			var highest = playersDecending.First().CflCentralId;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByFirstNameTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.FirstName, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.FirstName, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().FirstName;
			var highest = playersDecending.First().FirstName;

			var expected = true;
			var actual = highest.CompareTo(lowest) == 1;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByMiddleNameTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.MiddleName, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.MiddleName, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().MiddleName;
			var highest = playersDecending.First().MiddleName;

			var expected = true;
			var actual = highest.CompareTo(lowest) == 1;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByLastNameTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.LastName, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.LastName, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().LastName;
			var highest = playersDecending.First().LastName;

			var expected = true;
			var actual = highest.CompareTo(lowest) == 1;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByBirthDateTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.BirthDate, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.BirthDate, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().BirthDate;
			var highest = playersDecending.First().BirthDate;

			var expected = true;
			var actual = highest.CompareTo(lowest) == 1;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByHeightTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.Height, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.Height, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().Height;
			var highest = playersDecending.First().Height;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByWeightTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.Weight, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.Weight, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().Weight;
			var highest = playersDecending.First().Weight;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByRookieYearTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.RookieYear, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.RookieYear, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().RookieYear;
			var highest = playersDecending.First().RookieYear;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByForeignPlayerTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.ForeignPlayer, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.ForeignPlayer, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().ForeignPlayer;
			var highest = playersDecending.First().ForeignPlayer;

			var expected = true;
			var actual = highest != lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortBySchoolIdTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.SchoolId, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.SchoolId, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().School.SchoolId;
			var highest = playersDecending.First().School.SchoolId;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortBySchoolNameTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.SchoolName, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.SchoolName, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().School.Name;
			var highest = playersDecending.First().School.Name;

			var expected = true;
			var actual = highest.CompareTo(lowest) == 1;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByPositionIdTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.PositionId, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.PositionId, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().Position.PositionId;
			var highest = playersDecending.First().Position.PositionId;

			var expected = true;
			var actual = highest > lowest;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByPositionAbbreviationTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.PositionAbbreviation, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.PositionAbbreviation, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().Position.Abbreviation;
			var highest = playersDecending.First().Position.Abbreviation;

			var expected = true;
			var actual = highest.CompareTo(lowest) == 1;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SortByOffenceDefenceOrSpecialTest()
		{
			var client = GetClient();

			var ascendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.OffenceDefenceOrSpecial, SortOrder.Ascending) } };
			var descendingOptions = new PlayersRequestOptions { Sorts = new[] { new PlayerSort(PlayerSortTypes.OffenceDefenceOrSpecial, SortOrder.Descending) } };

			var playersAscending = client.GetPlayers(1, 20, ascendingOptions);
			var playersDecending = client.GetPlayers(1, 20, descendingOptions);

			var lowest = playersAscending.First().Position.OffenceDefenceOrSpecial;
			var highest = playersDecending.First().Position.OffenceDefenceOrSpecial;

			var expected = true;
			var actual = highest.CompareTo(lowest) == 1;

			Assert.AreEqual(expected, actual);
		}
	}
}
