using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.TeamLeaders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Tests.Client.TeamLeaders
{
	[TestClass]
	public class TeamLeadersClientTests : ClientTestsBase
	{

		private TeamLeadersClient GetClient()
		{
			return new TeamLeadersClient(GetApiKey());
		}

		[TestMethod]
		public void Get2015AllCategoriesTest()
		{
			var client = GetClient();

			var leaders = client.GetAllCategories(2015);

			Assert.IsNotNull(leaders.TotalYards);
			Assert.IsNotNull(leaders.PassingYards);
			Assert.IsNotNull(leaders.PassingTouchdowns);
			Assert.IsNotNull(leaders.RushingYards);
			Assert.IsNotNull(leaders.RushingTouchdowns);
			Assert.IsNotNull(leaders.Sacks);
			Assert.IsNotNull(leaders.Interceptions);
			Assert.IsNotNull(leaders.FumblesForced);
			Assert.IsNotNull(leaders.PassesDefended);
		}

		[TestMethod]
		public void Get2015AllCategoriesTeamFilterTest()
		{
			var client = GetClient();

			var leaders = client.GetAllCategories(2015, options: new TeamLeadersRequestOptions { Filters = new[] { TeamLeadersFilterFactory.TeamId.EqualTo(1) } });

			var expected = 1;

			Assert.AreEqual(expected, leaders.TotalYards.Count());
			Assert.AreEqual(expected, leaders.PassingYards.Count());
			Assert.AreEqual(expected, leaders.PassingTouchdowns.Count());
			Assert.AreEqual(expected, leaders.RushingYards.Count());
			Assert.AreEqual(expected, leaders.RushingTouchdowns.Count());
			Assert.AreEqual(expected, leaders.Sacks.Count());
			Assert.AreEqual(expected, leaders.Interceptions.Count());
			Assert.AreEqual(expected, leaders.FumblesForced.Count());
			Assert.AreEqual(expected, leaders.PassesDefended.Count());
		}

		[TestMethod]
		public void Get2015FumblesForcedTest()
		{
			var client = GetClient();

			var leaders = client.GetFumblesForced(2015);

			var expected = 21;
			var actual = leaders.First().FumblesForced;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015InterceptionsTest()
		{
			var client = GetClient();

			var leaders = client.GetInterceptions(2015);

			var expected = 26;
			var actual = leaders.First().Interceptions;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015PassesDefendedTest()
		{
			var client = GetClient();

			var leaders = client.GetPassesDefended(2015);

			var expected = 62;
			var actual = leaders.First().PassesDefended;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015PassingTouchdownsTest()
		{
			var client = GetClient();

			var leaders = client.GetPassingTouchdowns(2015);

			var expected = 37;
			var actual = leaders.First().PassingTouchdowns;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015PassingYardsTest()
		{
			var client = GetClient();

			var leaders = client.GetPassingYards(2015);

			var expected = 5806;
			var actual = leaders.First().PassingYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015PassingYardsEndDateFilterTest()
		{
			var client = GetClient();

			var leaders = client.GetPassingYards(2015, options: new TeamLeadersRequestOptions { Filters = new[] { TeamLeadersFilterFactory.EndDate.LessThan(new DateTime(2015, 08, 01))} });

			var expected = 1855;
			var actual = leaders.FirstOrDefault()?.PassingYards;

			Assert.IsNotNull(actual, client.LastRequestUrl);
			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015RushingTouchdownsTest()
		{
			var client = GetClient();

			var leaders = client.GetRushingTouchdowns(2015);

			var expected = 18;
			var actual = leaders.First().RushingTouchdowns;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015RushingYardsTest()
		{
			var client = GetClient();

			var leaders = client.GetRushingYards(2015);

			var expected = 2150;
			var actual = leaders.First().RushingYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015SacksTest()
		{
			var client = GetClient();

			var leaders = client.GetSacks(2015);

			var expected = 62;
			var actual = leaders.First().Sacks;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015TotalYardsTest()
		{
			var client = GetClient();

			var leaders = client.GetTotalYards(2015);

			var expected = 7342;
			var actual = leaders.First().TotalYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015TotalYardsForWeekTest()
		{
			var client = GetClient();

			var leaders = client.GetTotalYards(2015, options: new TeamLeadersRequestOptions { Filters = new[] { TeamLeadersFilterFactory.Week.EqualTo(2) } });

			var expected = 587;
			var actual = leaders.First().TotalYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}
	}
}
