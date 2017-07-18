using System;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using mdryden.cflapi.v1.Client.Leaders;
using mdryden.cflapi.v1.Models.Leaders;

namespace mdryden.cflapi.v1.Tests.Models.Leaders
{
	[TestClass]
	public class LeadersTests : DeserializationTestsBase
	{		

		[TestMethod]
		public void Convert1Test()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetConvert1(2015);

			TryDeserialize<DataArrayContainer<PlayerConverts1>>(client.LastResponse);
		}

		[TestMethod]
		public void Convert2Test()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetConvert2(2015);

			TryDeserialize<DataArrayContainer<PlayerConverts2>>(client.LastResponse);
		}

		[TestMethod]
		public void DefenceLeadersTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetDefence(2015);

			TryDeserialize<DataContainer<Defence>>(client.LastResponse);
		}

		[TestMethod]
		public void FieldGoalMissedReturnYardsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetFieldGoalMissedReturnYards(2015);

			TryDeserialize<DataArrayContainer<PlayerFieldGoalMissedReturnYards>>(client.LastResponse);
		}

		[TestMethod]
		public void FieldGoalsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetFieldGoals(2015);

			TryDeserialize<DataArrayContainer<PlayerFieldGoals>>(client.LastResponse);
		}

		[TestMethod]
		public void FumblesForcedTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetFumblesForced(2015);

			TryDeserialize<DataArrayContainer<PlayerFumblesForced>>(client.LastResponse);
		}

		[TestMethod]
		public void FumblesRecoveriesTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetFumblesRecoveries(2015);

			TryDeserialize<DataArrayContainer<PlayerFumblesRecoveries>>(client.LastResponse);
		}

		[TestMethod]
		public void InterceptionsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetInterceptions(2015);

			TryDeserialize<DataArrayContainer<Offence>>(client.LastResponse);
		}

		[TestMethod]
		public void KickingTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetKicking(2015);

			TryDeserialize<DataArrayContainer<PlayerKicking>>(client.LastResponse);
		}

		[TestMethod]
		public void KickoffReturnYardsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetKickoffReturnYards(2015);

			TryDeserialize<DataArrayContainer<PlayerKickoffReturnYards>>(client.LastResponse);
		}

		[TestMethod]
		public void KickoffYardsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetKickoffYards(2015);

			TryDeserialize<DataArrayContainer<PlayerKickoffYards>>(client.LastResponse);
		}

		[TestMethod]
		public void KicksBlockedTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetKicksBlocked(2015);

			TryDeserialize<DataArrayContainer<PlayerKicksBlocked>>(client.LastResponse);
		}

		[TestMethod]
		public void OffenceLeadersTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetOffence(2015);

			TryDeserialize<DataContainer<Offence>>(client.LastResponse);
		}

		[TestMethod]
		public void PassingTouchdownsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetPassingTouchdowns(2015);

			TryDeserialize<DataArrayContainer<PlayerPassingTouchdowns>>(client.LastResponse);
		}

		[TestMethod]
		public void PassingYardsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetPassingYards(2015);

			TryDeserialize<DataArrayContainer<PlayerPassingYards>>(client.LastResponse);
		}

		[TestMethod]
		public void ReceivingCaughtTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetReceivingCaught(2015);

			TryDeserialize<DataArrayContainer<PlayerReceivingCaught>>(client.LastResponse);
		}

		[TestMethod]
		public void ReceivingTargetedTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetReceivingTargeted(2015);

			TryDeserialize<DataArrayContainer<PlayerReceivingTargeted>>(client.LastResponse);
		}

		[TestMethod]
		public void ReceivingTouchdownsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetReceivingTouchdowns(2015);

			TryDeserialize<DataArrayContainer<PlayerReceivingYards>>(client.LastResponse);
		}

		[TestMethod]
		public void ReceivingYardsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetReceivingYards(2015);

			TryDeserialize<DataArrayContainer<PlayerReceivingYards>>(client.LastResponse);
		}

		[TestMethod]
		public void ReturnsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetReturns(2015);

			TryDeserialize<DataArrayContainer<PlayerReturns>>(client.LastResponse);
		}

		[TestMethod]
		public void ReturnYardsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetReturnYards(2015);

			TryDeserialize<DataArrayContainer<PlayerReturnYards>>(client.LastResponse);
		}

		[TestMethod]
		public void RushingTouchdownsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetRushingTouchdowns(2015);

			TryDeserialize<DataArrayContainer<PlayerRushingTouchdowns>>(client.LastResponse);
		}

		[TestMethod]
		public void RushingYardsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetRushingYards(2015);

			TryDeserialize<DataArrayContainer<PlayerRushingYards>>(client.LastResponse);
		}

		[TestMethod]
		public void SacksTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetSacks(2015);

			TryDeserialize<DataArrayContainer<PlayerSacks>>(client.LastResponse);
		}

		[TestMethod]
		public void SpecialTeamsLeadersTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetSpecialTeams(2015);

			TryDeserialize<DataContainer<SpecialTeams>>(client.LastResponse);
		}

		[TestMethod]
		public void TacklesDefensiveTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetTacklesDefensive(2015);

			TryDeserialize<DataArrayContainer<PlayerTacklesDefensive>>(client.LastResponse);
		}

		[TestMethod]
		public void TacklesSpecialTeamsTest()
		{
			var client = new LeadersClient(GetApiKey());

			client.GetTacklesSpecialTeams(2015);

			TryDeserialize<DataArrayContainer<PlayerTacklesSpecialTeams>>(client.LastResponse);
		}

	}
}
