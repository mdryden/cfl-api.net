using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Players;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.Tests.Client.Players
{
	[TestClass]
	public class PlayerFilterLessThanTests : ClientTestsBase
	{
		private PlayersClient GetClient()
		{
			return new PlayersClient(GetApiKey());
		}

		[TestMethod]
		public void CflCentralIdTest()
		{
			var client = GetClient();

			var filterValue = 148636;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.CflCentralId(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().CflCentralId < filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void FirstNameTest()
		{
			var client = GetClient();

			var filterValue = "Tokumbo";

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.FirstName(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().FirstName.CompareTo(filterValue) == -1;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void MiddleNameTest()
		{
			var client = GetClient();

			var filterValue = "Danny";

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.MiddleName(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().MiddleName.CompareTo(filterValue) == -1;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void LastNameTest()
		{
			var client = GetClient();

			var filterValue = "Acy";

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.LastName(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().LastName.CompareTo(filterValue) == -1;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void BirthDateTest()
		{
			var client = GetClient();

			var filterValue = new DateTime(1982, 07, 26);

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.BirthDate(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = DateTime.Parse(players.First().BirthDate) < filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		//[TestMethod]
		//public void HeightTest()
		//{
		//	var client = GetClient();

		//	var feet = 6;
		//	var inches = 6;

		//	var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.Height(FilterOperators.LessThan, feet, inches) } };

		//	var players = client.GetPlayers(1, 20, options);

		//	var expected = true;
  //          var actual = players.First().Height < decimal.Parse($"{feet}.{inches.ToString("00")}");

		//	Assert.AreEqual(expected, actual, client.LastRequestUrl);
		//}

		[TestMethod]
		public void WeightTest()
		{
			var client = GetClient();

			var filterValue = 220;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.Weight(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().Weight < filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void RookieYearTest()
		{
			var client = GetClient();

			var filterValue = 2007;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.RookieYear(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First(p => p.RookieYear != null).RookieYear < filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}
		
		[TestMethod]
		public void ForeignPlayerTest()
		{
			var client = GetClient();

			var filterValue = true;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.ForeignPlayer(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().ForeignPlayer != filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SchoolIdTest()
		{
			var client = GetClient();

			var filterValue = 116;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.SchoolId(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().School.SchoolId < filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SchoolNameTest()
		{
			var client = GetClient();

			var filterValue = "Western University";

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.SchoolName(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().School.Name.CompareTo(filterValue) == -1;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void PositionIdTest()
		{
			var client = GetClient();

			var filterValue = PositionIds.RunningBack;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.PositionId(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().Position.PositionId < filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void PositionAbbreviationTest()
		{
			var client = GetClient();

			var filterValue = PositionAbbreviations.Linebacker;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.PositionAbbreviation(FilterOperators.LessThan, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().Position.Abbreviation.CompareTo(filterValue) == -1;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[Ignore] // broken = http://api.cfl.ca/v1/players?filter[offence_defence_or_special][eq]=O
		[TestMethod]
		public void OffenceDefenceOrSpecialTest()
		{
			//var client = GetClient();

			//var filterValue = OffenceDefenceOrSpecialValues.SpecialTeams;

			//var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.OffenceDefenceOrSpecial(FilterOperators.LessThan, filterValue) } };

			//var players = client.GetPlayers(1, 20, options);

			//var expected = true;
			//var actual = players.First().Position.OffenceDefenceOrSpecial < filterValue;

			//Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}
	}
}
