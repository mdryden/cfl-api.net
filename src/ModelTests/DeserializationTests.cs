using System;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace mdryden.cflapi.v1.ModelTests
{
	[TestClass]
	public class DeserializationTests
	{

		[TestMethod]
		public void FullGameTest()
		{
			var input = Properties.Resources.Game2266;
			
			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<GamesContainer>(input, settings);

		}

		[TestMethod]
		public void QuarterbackTest()
		{
			var input = Properties.Resources.PlayerQuarterback;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<PlayersContainer>(input, settings);

		}

		[TestMethod]
		public void RunningBackTest()
		{
			var input = Properties.Resources.PlayerRunningBack;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<PlayersContainer>(input, settings);

		}

	}
}
