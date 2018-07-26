using System;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using mdryden.cflapi.v1.Models.Leaders;
using mdryden.cflapi.v1.Client;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Tests.Models.Leaders
{
	[TestClass]
	public class LeadersTests : DeserializationTestsBase
	{		

		[TestMethod]
		public void Convert1Test()
		{
			IList<PlayerConverts1> leaders = Endpoint.Leaders.Convert1s(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void Convert2Test()
		{
			IList<PlayerConverts2> leaders = Endpoint.Leaders.Convert2s(2015).Invoke();

			Assert.IsNotNull(leaders);
		}
		
		[TestMethod]
		public void FieldGoalMissedReturnYardsTest()
		{
			IList<PlayerFieldGoalMissedReturnYards> leaders = Endpoint.Leaders.FieldGoalMissedReturnYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void FieldGoalsTest()
		{
			IList<PlayerFieldGoals> leaders = Endpoint.Leaders.FieldGoals(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void FumblesForcedTest()
		{
			IList<PlayerFumblesForced> leaders = Endpoint.Leaders.FumblesForced(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void FumblesRecoveriesTest()
		{
			IList<PlayerFumblesRecoveries> leaders = Endpoint.Leaders.FumblesRecoveries(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void InterceptionsTest()
		{
			IList<PlayerInterceptions> leaders = Endpoint.Leaders.Interceptions(2015).Invoke();

			Assert.IsNotNull(leaders);
		}
		

		[TestMethod]
		public void KickoffReturnYardsTest()
		{
			IList<PlayerKickoffReturnYards> leaders = Endpoint.Leaders.KickoffReturnYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void KickoffYardsTest()
		{
			IList<PlayerKickoffYards> leaders = Endpoint.Leaders.KickoffYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void KicksBlockedTest()
		{
			IList<PlayerKicksBlocked> leaders = Endpoint.Leaders.KicksBlocked(2015).Invoke();

			Assert.IsNotNull(leaders);
		}
		
		[TestMethod]
		public void PassingTouchdownsTest()
		{
			IList<PlayerPassingTouchdowns> leaders = Endpoint.Leaders.PassingTouchdowns(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void PassingYardsTest()
		{
			IList<PlayerPassingYards> leaders = Endpoint.Leaders.PassingYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void ReceivingCaughtTest()
		{
			IList<PlayerReceivingCaught> leaders = Endpoint.Leaders.ReceivingCaught(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void ReceivingTargetedTest()
		{
			IList<PlayerReceivingTargeted> leaders = Endpoint.Leaders.ReceivingTargeted(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void ReceivingTouchdownsTest()
		{
			IList<PlayerReceivingTouchdowns> leaders = Endpoint.Leaders.ReceivingTouchdowns(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void ReceivingYardsTest()
		{
			IList<PlayerReceivingYards> leaders = Endpoint.Leaders.ReceivingYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}
		
		[TestMethod]
		public void RushingTouchdownsTest()
		{
			IList<PlayerRushingTouchdowns> leaders = Endpoint.Leaders.RushingTouchdowns(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void RushingYardsTest()
		{
			IList<PlayerRushingYards> leaders = Endpoint.Leaders.RushingYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void SacksTest()
		{
			IList<PlayerSacks> leaders = Endpoint.Leaders.Sacks(2015).Invoke();

			Assert.IsNotNull(leaders);
		}
		
		[TestMethod]
		public void TacklesDefensiveTest()
		{
			IList<PlayerTacklesDefensive> leaders = Endpoint.Leaders.TacklesDefensive(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void TacklesSpecialTeamsTest()
		{
			IList<PlayerTacklesSpecialTeams> leaders = Endpoint.Leaders.TacklesSpecialTeams(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

	}
}
