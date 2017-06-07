using System;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using mdryden.cflapi.v1.Client.Standings;
using System.Configuration;
using mdryden.cflapi.v1.Client.Players;

namespace mdryden.cflapi.v1.Tests.Models.Players
{
	[TestClass]
	public class PlayersTests : DeserializationTestsBase
	{
		

		[TestMethod]
		public void QuarterbackTest()
		{
			var client = new PlayersClient(GetApiKey());
			client.GetPlayer(158222, true, true);

			TryDeserialize<DataArrayContainer<Player>>(client.LastResponse);
		}

		[TestMethod]
		public void RunningBackTest()
		{
			var client = new PlayersClient(GetApiKey());
			client.GetPlayer(80119, true, true);

			TryDeserialize<DataArrayContainer<Player>>(client.LastResponse);
		}

		[TestMethod]
		public void WideReceiverTest()
		{
			var client = new PlayersClient(GetApiKey());
			client.GetPlayer(117995, true, true);

			TryDeserialize<DataArrayContainer<Player>>(client.LastResponse);
		}

		[TestMethod]
		public void DefensiveLinemanTest()
		{

			var client = new PlayersClient(GetApiKey());
			client.GetPlayer(148766, true, true);

			TryDeserialize<DataArrayContainer<Player>>(client.LastResponse);
		}

		[TestMethod]
		public void PunterTest()
		{
			var client = new PlayersClient(GetApiKey());
			client.GetPlayer(127305, true, true);

			TryDeserialize<DataArrayContainer<Player>>(client.LastResponse);
		}

		[TestMethod]
		public void KickerTest()
		{
			var client = new PlayersClient(GetApiKey());
			client.GetPlayer(159141, true, true);
			
			TryDeserialize<DataArrayContainer<Player>>(client.LastResponse);
		}
		

	}
}
