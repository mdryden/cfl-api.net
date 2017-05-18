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
	public class PlayerFilterGreaterThanOrEqualToOrEqualToTests : ClientTestsBase
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

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.CflCentralId.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().CflCentralId >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void FirstNameTest()
		{
			var client = GetClient();

			var filterValue = "Tokumbo";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.FirstName.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().FirstName.CompareTo(filterValue) >= 0;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void MiddleNameTest()
		{
			var client = GetClient();

			var filterValue = "Danny";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.MiddleName.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().MiddleName.CompareTo(filterValue) >= 0;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void LastNameTest()
		{
			var client = GetClient();

			var filterValue = "Acy";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.LastName.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().LastName.CompareTo(filterValue) >= 0;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void BirthDateTest()
		{
			var client = GetClient();

			var filterValue = new DateTime(1982, 07, 26);

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.BirthDate.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = DateTime.Parse(players.First().BirthDate) >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		//[TestMethod]
		//public void HeightTest()
		//{
		//	var client = GetClient();

		//	var feet = 6;
		//	var inches = 6;

		//	var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.Height(FilterOperators.GreaterThanOrEqualTo, feet, inches) } };

		//	var players = client.GetPlayers(1, 20, options);

		//	var expected = true;
  //          var actual = players.First().Height >= decimal.Parse($"{feet}.{inches.ToString("00")}");

		//	Assert.AreEqual(expected, actual, client.LastRequestUrl);
		//}

		[TestMethod]
		public void WeightTest()
		{
			var client = GetClient();

			var filterValue = 220;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.Weight.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().Weight >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void RookieYearTest()
		{
			var client = GetClient();

			var filterValue = 2007;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.RookieYear.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().RookieYear >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}
		
		[TestMethod]
		public void ForeignPlayerTest()
		{
			var client = GetClient();

			var filterValue = false;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.ForeignPlayer.GreaterThanOrEqualTo(filterValue) } };

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

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.SchoolId.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().School.SchoolId >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void SchoolNameTest()
		{
			var client = GetClient();

			var filterValue = "Western University";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.SchoolName.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().School.Name.CompareTo(filterValue) >= 0;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void PositionIdTest()
		{
			var client = GetClient();

			var filterValue = PositionIds.Quarterback;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.PositionId.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().Position.PositionId >= filterValue;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void PositionAbbreviationTest()
		{
			var client = GetClient();

			var filterValue = PositionAbbreviations.Linebacker;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.PositionAbbreviation.GreaterThanOrEqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = true;
			var actual = players.First().Position.Abbreviation.CompareTo(filterValue) >= 0;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[Ignore] // broken = http://api.cfl.ca/v1/players?filter[offence_defence_or_special][eq]=O
		[TestMethod]
		public void OffenceDefenceOrSpecialTest()
		{
			//var client = GetClient();

			//var filterValue = OffenceDefenceOrSpecialValues.SpecialTeams;

			//var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.OffenceDefenceOrSpecial.GreaterThanOrEqualTo(filterValue) } };

			//var players = client.GetPlayers(1, 20, options);

			//var expected = true;
			//var actual = players.First().Position.OffenceDefenceOrSpecial >= filterValue;

			//Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void GameDateEllingsonTest()
		{
			var client = GetClient();

			var filterValue = new DateTime(2015, 06, 25);

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.GameDate.GreaterThanOrEqualTo(filterValue) } };

			var player = client.GetPlayer(159820, includeGameByGame: true, options: options);

			var expected = filterValue.ToString("yyyy-MM-dd");
			var actual = player.GameByGame?.Receiving?.FirstOrDefault().GameDate;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}
	}
}
