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
	public class PlayerFilterEqualsTests : ClientTestsBase
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

			var options = PlayersRequestOptions.Create().WithFilter().CflCentralId.EqualTo(filterValue);

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().CflCentralId;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void FirstNameTest()
		{
			var client = GetClient();

			var filterValue = "Tokumbo";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.FirstName.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().FirstName;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void MiddleNameTest()
		{
			var client = GetClient();

			var filterValue = "Danny";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.MiddleName.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().MiddleName;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void LastNameTest()
		{
			var client = GetClient();

			var filterValue = "Acy";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.LastName.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue.ToUpper();
			var actual = players.First().LastName;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void BirthDateTest()
		{
			var client = GetClient();

			var filterValue = new DateTime(1982, 07, 26);

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.BirthDate.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue.ToString("yyyy-MM-dd");
			var actual = players.First().BirthDate;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void HeightTest()
		{
			var client = GetClient();

			var feet = 6;
			var inches = 6;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.Height.EqualTo(feet, inches) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = $"{feet}.{inches.ToString("00")}"; ;
			var actual = players.First().Height;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void WeightTest()
		{
			var client = GetClient();

			var filterValue = 220;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.Weight.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().Weight;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void RookieYearTest()
		{
			var client = GetClient();

			var filterValue = 2007;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.RookieYear.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().RookieYear;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void ForeignPlayerTest()
		{
			var client = GetClient();

			var filterValue = true;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.ForeignPlayer.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().ForeignPlayer;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void SchoolIdTest()
		{
			var client = GetClient();

			var filterValue = 116;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.SchoolId.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().School.SchoolId;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void SchoolNameTest()
		{
			var client = GetClient();

			var filterValue = "Western University";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.SchoolName.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().School.Name;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void PositionIdTest()
		{
			var client = GetClient();

			var filterValue = PositionIds.Quarterback;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.PositionId.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().Position.PositionId;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void PositionAbbreviationTest()
		{
			var client = GetClient();

			var filterValue = PositionAbbreviations.Linebacker;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.PositionAbbreviation.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().Position.Abbreviation;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[Ignore] //Issue #6
		[TestMethod]
		public void OffenceDefenceOrSpecialTest()
		{
			var client = GetClient();

			var filterValue = OffenceDefenceOrSpecialValues.SpecialTeams;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.OffenceDefenceOrSpecial.EqualTo(filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.FirstOrDefault()?.Position?.OffenceDefenceOrSpecial;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[TestMethod]
		public void SeasonTest()
		{
			var client = GetClient();

			var filterValue = 2015;

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.Season.EqualTo(filterValue) } };

			var players = client.GetPlayers(options: options);

			var expected = 161500; // Chris Ackie - there's no good way to test the result here, because the season doesn't actually appear in the response data
			var actual = players.First().CflCentralId;

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);
		}

		[Ignore] // Issue #7
		[TestMethod]
		public void PlayersPage77Test()
		{
			var client = GetClient();

			var players = client.GetPlayers(pageNumber: 77, options: new PlayersRequestOptions { Sorts2 = new[] { FluentPlayersSortFactory.CflCentralId.Ascending } });

			var expected = 20;
			var actual = players.Count();

			Assert.AreEqual(expected, actual, Endpoint.RequestClient.LastRequestUrl);

		}

	}
}
