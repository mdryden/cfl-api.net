using System;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mdryden.cflapi.v1.Models.TeamLeaders;
using mdryden.cflapi.v1.Client;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Tests.Models.TeamLeaders
{
	[TestClass]
	public class TeamLeadersTests : DeserializationTestsBase
	{
		[TestMethod]
		public void AllCategoriesTest()
		{
			IList<TeamAll> leaders = Endpoint.TeamLeaders.AllCategories(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void FumblesForcedTest()
		{
			IList<TeamFumblesForced> leaders = Endpoint.TeamLeaders.FumblesForced(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void InterceptionsTest()
		{
			IList<TeamInterceptions> leaders = Endpoint.TeamLeaders.Interceptions(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void PassesDefendedTest()
		{
			IList<TeamPassesDefended> leaders = Endpoint.TeamLeaders.PassesDefended(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void PassingTouchdownsTest()
		{
			IList<TeamPassingTouchdowns> leaders = Endpoint.TeamLeaders.PassingTouchdowns(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void PassingYardsTest()
		{
			IList<TeamPassingYards> leaders = Endpoint.TeamLeaders.PassingYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void RushingTouchdownsTest()
		{
			IList<TeamRushingTouchdowns> leaders = Endpoint.TeamLeaders.RushingTouchdowns(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void RushingYardsTest()
		{
			IList<TeamRushingYards> leaders = Endpoint.TeamLeaders.RushingYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void SacksTest()
		{
			IList<TeamSacks> leaders = Endpoint.TeamLeaders.Sacks(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

		[TestMethod]
		public void TotalYardsTest()
		{
			IList<TeamTotalYards> leaders = Endpoint.TeamLeaders.TotalYards(2015).Invoke();

			Assert.IsNotNull(leaders);
		}

	}
}
