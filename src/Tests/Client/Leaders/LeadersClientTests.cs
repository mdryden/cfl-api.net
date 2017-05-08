using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Leaders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Tests.Client.Leaders
{
	[TestClass]
	public class LeadersClientTests : ClientTestsBase
	{

		private LeadersClient GetClient()
		{
			return new LeadersClient(GetApiKey());
		}

		[TestMethod]
		public void Get2015Convert1LeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetConvert1(2015);

			var expected = 49;
			var actual = leaders.First().Converts1;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015Convert2LeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetConvert2(2015);

			var expected = 9;
			var actual = leaders.First().Converts2;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015FieldGoalsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetFieldGoals(2015, includeExtendedData: true);

			var expected = 42;
			var actual = leaders.First().FieldGoals;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
			Assert.IsNotNull(leaders.First().ExtendedData);
		}

		[TestMethod]
		public void Get2015FieldGoalMissedReturnYardsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetFieldGoalMissedReturnYards(2015);

			var expected = 179;
			var actual = leaders.First().FieldMissedGoalReturnYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015FumblesForcedLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetFumblesForced(2015);

			var expected = 4;
			var actual = leaders.First().FumblesForced;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015FumblesRecoveriesLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetFumblesRecoveries(2015);

			var expected = 7;
			var actual = leaders.First().FumblesRecoveries;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015InterceptionsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetInterceptions(2015);

			var expected = 6;
			var actual = leaders.First().Interceptions;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015KickingLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetKicking(2015);

			var expected = 6118;
			var actual = leaders.First().Kicking;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015KickoffReturnYardsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetKickoffReturnYards(2015);

			var expected = 1168;
			var actual = leaders.First().KickoffReturnYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015KickoffYardsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetKickoffYards(2015);

			var expected = 5212;
			var actual = leaders.First().KickoffYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015KicksBlockedLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetKicksBlocked(2015);

			var expected = 1;
			var actual = leaders.First().KicksBlocked;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015PassingTouchdownsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetPassingTouchdowns(2015);

			var expected = 33;
			var actual = leaders.First().PassingTouchdowns;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015PassingYardsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetPassingYards(2015);

			var expected = 5693;
			var actual = leaders.First().PassingYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015ReceivingTouchdownsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetReceivingTouchdowns(2015);

			var expected = 10;
			var actual = leaders.First().ReceivingTouchdowns;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015ReceivingTouchdownsTeamFilterTest()
		{
			var client = GetClient();

			var leaders = client.GetReceivingTouchdowns(2015, options: new LeadersRequestOptions { Filters = new[] { new LeadersFilter(LeadersFilterTypes.TeamId, FilterOperators.EqualTo, "1") } });

			var expected = 9;
			var actual = leaders.First().ReceivingTouchdowns;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}
		
		[TestMethod]
		public void Get2015ReceivingTouchdownsEndDateFilterTest()
		{
			var client = GetClient();

			var leaders = client.GetReceivingTouchdowns(2015, options: new LeadersRequestOptions { Filters = new[] { new LeadersFilter(LeadersFilterTypes.EndDate, FilterOperators.LessThan, "2015-08-01") } });

			var expected = 160253; // Eric Rogers
			var actual = leaders.First().CflCentralId;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015ReceivingYardsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetReceivingYards(2015);

			var expected = 1448;
			var actual = leaders.First().ReceivingYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015ReceivingTargetedLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetReceivingTargeted(2015);

			var expected = 160;
			var actual = leaders.First().ReceivingTargeted;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015ReturnsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetReturns(2015);

			var expected = 93;
			var actual = leaders.First().Returns;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015ReturnYardsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetReturnYards(2015);

			var expected = 1073;
			var actual = leaders.First().ReturnYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015RushingTouchdownsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetRushingTouchdowns(2015);

			var expected = 9;
			var actual = leaders.First().RushingTouchdowns;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015RushingYardsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetRushingYards(2015);

			var expected = 1059;
			var actual = leaders.First().RushingYards;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015SacksLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetSacks(2015);

			var expected = 19;
			var actual = leaders.First().Sacks;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015TacklesDefensiveLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetTacklesDefensive(2015);

			var expected = 114;
			var actual = leaders.First().TacklesDefensive;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015TacklesDefensivePageSizeTest()
		{
			var client = GetClient();

			var leaders = client.GetTacklesDefensive(2015, topX: 2);

			var expected = 2;
			var actual = leaders.Count();

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015TacklesSpecialTeamsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetTacklesSpecialTeams(2015);

			var expected = 24;
			var actual = leaders.First().TacklesSpecialTeams;

			Assert.AreEqual(expected, actual, client.LastRequestUrl);
		}

		[TestMethod]
		public void Get2015OffenceLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetOffence(2015);
			
			Assert.IsNotNull(leaders.PassingYards);
			Assert.IsNotNull(leaders.PassingTouchdowns);
			Assert.IsNotNull(leaders.RushingYards);
			Assert.IsNotNull(leaders.RushingTouchdowns);
			Assert.IsNotNull(leaders.ReceivingYards);
			Assert.IsNotNull(leaders.ReceivingTouchdowns);
			Assert.IsNotNull(leaders.ReceivingCaught);
			Assert.IsNotNull(leaders.ReceivingTargeted);
		}

		[TestMethod]
		public void Get2015DefenceLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetDefence(2015);

			Assert.IsNotNull(leaders.TacklesDefensive);
			Assert.IsNotNull(leaders.Sacks);
			Assert.IsNotNull(leaders.Interceptions);
			Assert.IsNotNull(leaders.FumblesForced);
			Assert.IsNotNull(leaders.FumblesRecoveries);
		}

		[TestMethod]
		public void Get2015SpecialTeamsLeadersTest()
		{
			var client = GetClient();

			var leaders = client.GetSpecialTeams(2015);

			Assert.IsNotNull(leaders.FieldGoals);
			Assert.IsNotNull(leaders.Kicking);
			Assert.IsNotNull(leaders.Returns);
			Assert.IsNotNull(leaders.ReturnYards);
			Assert.IsNotNull(leaders.FieldGoalMissedReturnYards);
			Assert.IsNotNull(leaders.KickoffYards);
			Assert.IsNotNull(leaders.TacklesSpecialTeams);
			Assert.IsNotNull(leaders.KicksBlocked);
			Assert.IsNotNull(leaders.KickoffReturnYards);
			Assert.IsNotNull(leaders.Converts1);
			Assert.IsNotNull(leaders.Converts2);
		}
	}
}
