using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client;
using mdryden.cflapi.v1.Client.Players;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.Tests.Client.Players
{
	[TestClass]
	public class PlayerFilterInTests : ClientTestsBase
	{
		private PlayersClient GetClient()
		{
			return new PlayersClient(GetApiKey());
		}
		
		[TestMethod]
		public void LastNameInTest()
		{
			var client = GetClient();

			var filterValue = "Durant,Muamba";

			var options = new PlayersRequestOptions { Filters = new[] { PlayersFilterFactory.LastName.In(filterValue) } };

			var players = client.GetPlayers(options: options);

			var durant = players.FirstOrDefault(p => string.Equals(p.LastName, "Durant", StringComparison.InvariantCultureIgnoreCase));
			var muamba = players.FirstOrDefault(p => string.Equals(p.LastName, "Muamba", StringComparison.InvariantCultureIgnoreCase));

			Assert.IsNotNull(durant, client.LastRequestUrl);
			Assert.IsNotNull(muamba, client.LastRequestUrl);

		}

		[TestMethod]
		public void RookieYearInTest()
		{
			//var client = GetClient();

			//var filterValue = "Durant,Muamba";

			//var options = new PlayersRequestOptions { Filters = new[] { PlayerFilter.RookieYear(FilterOperators.In, filterValue) } };

			//var players = client.GetPlayers(options: options);

			//var durant = players.FirstOrDefault(p => string.Equals(p.LastName, "Durant", StringComparison.InvariantCultureIgnoreCase));
			//var muamba = players.FirstOrDefault(p => string.Equals(p.LastName, "Muamba", StringComparison.InvariantCultureIgnoreCase));

			//Assert.IsNotNull(durant, client.LastRequestUrl);
			//Assert.IsNotNull(muamba, client.LastRequestUrl);

		}

	}
}
