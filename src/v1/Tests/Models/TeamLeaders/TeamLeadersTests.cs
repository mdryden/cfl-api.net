using System;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using mdryden.cflapi.v1.Client.TeamLeaders;
using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Tests.Models.TeamLeaders
{
	[TestClass]
	public class TeamLeadersTests : DeserializationTestsBase
	{
		[TestMethod]
		public void AllCategoriesTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetAllCategories(2015);

			TryDeserialize<DataContainer<TeamAll>>(client.LastResponse);
		}

		[TestMethod]
		public void FumblesForcedTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetFumblesForced(2015);

			TryDeserialize<DataArrayContainer<TeamFumblesForced>>(client.LastResponse);
		}

		[TestMethod]
		public void InterceptionsTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetInterceptions(2015);

			TryDeserialize<DataArrayContainer<TeamInterceptions>>(client.LastResponse);
		}

		[TestMethod]
		public void PassesDefendedTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetPassesDefended(2015);

			TryDeserialize<DataArrayContainer<TeamPassesDefended>>(client.LastResponse);
		}

		[TestMethod]
		public void PassingTouchdownsTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetPassingTouchdowns(2015);

			TryDeserialize<DataArrayContainer<TeamPassingTouchdowns>>(client.LastResponse);
		}

		[TestMethod]
		public void PassingYardsTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetPassingYards(2015);

			TryDeserialize<DataArrayContainer<TeamPassingYards>>(client.LastResponse);
		}

		[TestMethod]
		public void RushingTouchdownsTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetRushingTouchdowns(2015);

			TryDeserialize<DataArrayContainer<TeamRushingTouchdowns>>(client.LastResponse);
		}

		[TestMethod]
		public void RushingYardsTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetRushingYards(2015);

			TryDeserialize<DataArrayContainer<TeamRushingYards>>(client.LastResponse);
		}

		[TestMethod]
		public void SacksTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetSacks(2015);

			TryDeserialize<DataArrayContainer<TeamSacks>>(client.LastResponse);
		}

		[TestMethod]
		public void TotalYardsTest()
		{
			var client = new TeamLeadersClient(GetApiKey());

			client.GetTotalYards(2015);

			TryDeserialize<DataArrayContainer<TeamTotalYards>>(client.LastResponse);
		}

	}
}
