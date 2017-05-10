using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Games;
using mdryden.cflapi.v1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.Tests.Client.Games
{
	[TestClass]
	public class GameFilterInTests : ClientTestsBase
	{

		private GamesClient GetClient()
		{
			return new GamesClient(GetApiKey());
		}


		[TestMethod]
		public void WeekInTest()
		{
			var client = GetClient();
			
			var options = new GamesRequestOptions { Filters = new[] { GamesFilterFactory.Week.In(2, 9) } };

			var games = client.GetGames(options: options);

			var week2 = games.FirstOrDefault(g => g.Week == 2);
			var week9 = games.FirstOrDefault(g => g.Week == 9);

			Assert.IsNotNull(week2, client.LastRequestUrl);
			Assert.IsNotNull(week9, client.LastRequestUrl);

		}



	}
}
