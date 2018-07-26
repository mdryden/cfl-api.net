using System;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.Tests.Models.Players
{
	[TestClass]
	public class PlayersTests : DeserializationTestsBase
	{
		

		[TestMethod]
		public void QuarterbackTest()
		{
			Player player = Endpoint.Players.GetPlayer(158222).Invoke();

			Assert.IsNotNull(player);
		}

		[TestMethod]
		public void RunningBackTest()
		{
			Player player = Endpoint.Players.GetPlayer(80119).Invoke();

			Assert.IsNotNull(player);
		}

		[TestMethod]
		public void WideReceiverTest()
		{
			Player player = Endpoint.Players.GetPlayer(117995).Invoke();

			Assert.IsNotNull(player);
		}

		[TestMethod]
		public void DefensiveLinemanTest()
		{
			Player player = Endpoint.Players.GetPlayer(148766).Invoke();

			Assert.IsNotNull(player);
		}

		[TestMethod]
		public void PunterTest()
		{
			Player player = Endpoint.Players.GetPlayer(127305).Invoke();

			Assert.IsNotNull(player);
		}

		[TestMethod]
		public void KickerTest()
		{
			Player player = Endpoint.Players.GetPlayer(159141).Invoke();

			Assert.IsNotNull(player);
		}
		

	}
}
