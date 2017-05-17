using System;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using mdryden.cflapi.v1.Client.Standings;
using System.Configuration;

namespace mdryden.cflapi.v1.Tests.Models
{
	[TestClass]
	public class DeserializationTests
	{
		private string GetApiKey()
		{
			return ConfigurationManager.AppSettings["apiKey"];
		}

		private void TryDeserialize<T>(string response)
		{
			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<T>(response, settings);
		}

		[TestMethod]
		public void FullGameTest()
		{
			var input = Properties.Resources.Game2266;
			
			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataArrayContainer<Game>>(input, settings);

		}

		[TestMethod]
		public void QuarterbackTest()
		{
			var input = Properties.Resources.PlayerQuarterback;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataArrayContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void RunningBackTest()
		{
			var input = Properties.Resources.PlayerRunningBack;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataArrayContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void WideReceiverTest()
		{
			var input = Properties.Resources.PlayerWideReceiver;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataArrayContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void DefensiveLinemanTest()
		{
			var input = Properties.Resources.PlayerDefensiveLine;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataArrayContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void PunterTest()
		{
			var input = Properties.Resources.PlayerPunter;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataArrayContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void KickerTest()
		{
			var input = Properties.Resources.PlayerKicker;

			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var game = JsonConvert.DeserializeObject<DataArrayContainer<Player>>(input, settings);

		}

		[TestMethod]
		public void StandingsTest()
		{
			var client = new StandingsClient(GetApiKey());

			client.GetStandings(2015);

			TryDeserialize<DataContainer<v1.Models.Standings.SeasonContainer>>(client.LastResponse);
		}

	}
}
