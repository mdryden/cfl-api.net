﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Players;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.ClientTests.Players
{
	[TestClass]
	public class PlayerFilterNotEqualTests : ClientTestsBase
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

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.CflCentralId(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().CflCentralId;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void FirstNameTest()
		{
			var client = GetClient();

			var filterValue = "Tokumbo";

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.FirstName(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().FirstName;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void MiddleNameTest()
		{
			var client = GetClient();

			var filterValue = "Danny";

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.MiddleName(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().MiddleName;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void LastNameTest()
		{
			var client = GetClient();

			var filterValue = "Acy";

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.LastName(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue.ToUpper();
			var actual = players.First().LastName;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void BirthDateTest()
		{
			var client = GetClient();

			var filterValue = new DateTime(1982, 07, 26);

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.BirthDate(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue.ToString("yyyy-MM-dd");
			var actual = players.First().BirthDate;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void HeightTest()
		{
			var client = GetClient();

			var feet = 6;
			var inches = 6;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.Height(FilterOperators.NotEqualTo, feet, inches) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = decimal.Parse($"{feet}.{inches.ToString("00")}");
            var actual = players.First().Height;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void WeightTest()
		{
			var client = GetClient();

			var filterValue = 220;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.Weight(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().Weight;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void RookieYearTest()
		{
			var client = GetClient();

			var filterValue = 2007;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.RookieYear(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().RookieYear;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void ForeignPlayerTest()
		{
			var client = GetClient();

			var filterValue = true;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.ForeignPlayer(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().ForeignPlayer;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void SchoolIdTest()
		{
			var client = GetClient();

			var filterValue = 116;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.SchoolId(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().School.SchoolId;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void SchoolNameTest()
		{
			var client = GetClient();

			var filterValue = "Western University";

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.SchoolName(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().School.Name;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void PositionIdTest()
		{
			var client = GetClient();

			var filterValue = PositionIds.Quarterback;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.PositionId(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().Position.PositionId;

			Assert.AreNotEqual(expected, actual);
		}

		[TestMethod]
		public void PositionAbbreviationTest()
		{
			var client = GetClient();

			var filterValue = PositionAbbreviations.Linebacker;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.PositionAbbreviation(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().Position.Abbreviation;

			Assert.AreNotEqual(expected, actual);
		}

		[Ignore] // broken = http://api.cfl.ca/v1/players?filter[offence_defence_or_special][eq]=O
		[TestMethod]
		public void OffenceDefenceOrSpecialTest()
		{
			var client = GetClient();

			var filterValue = OffenceDefenceOrSpecialValues.SpecialTeams;

			var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.OffenceDefenceOrSpecial(FilterOperators.NotEqualTo, filterValue) } };

			var players = client.GetPlayers(1, 20, options);

			var expected = filterValue;
			var actual = players.First().Position.OffenceDefenceOrSpecial;

			Assert.AreNotEqual(expected, actual, client.LastRequestUrl);
		}
	}
}
