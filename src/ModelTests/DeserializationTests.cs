using System;
using mdryden.cflapi.v1.Models;
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
		public void PlayerTest()
		{
			var input = Properties.Resources.Player87742;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<PlayersContainer>(input, settings);

		}
	}
}
