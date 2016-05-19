using System;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace mdryden.cflapi.v1.Tests.Models
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

			var game = JsonConvert.DeserializeObject<DataContainer<Game>>(input, settings);

		}

		[TestMethod]
		public void QuarterbackTest()
		{
			var input = Properties.Resources.PlayerQuarterback;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void RunningBackTest()
		{
			var input = Properties.Resources.PlayerRunningBack;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void WideReceiverTest()
		{
			var input = Properties.Resources.PlayerWideReceiver;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void DefensiveLinemanTest()
		{
			var input = Properties.Resources.PlayerDefensiveLine;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void PunterTest()
		{
			var input = Properties.Resources.PlayerPunter;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void KickerTest()
		{
			var input = Properties.Resources.PlayerKicker;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataContainer<Player>>(input, settings);

		}

	}
}
