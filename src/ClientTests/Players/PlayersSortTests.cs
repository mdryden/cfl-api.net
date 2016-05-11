using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mdryden.cflapi.v1.ClientTests.Players
{
	[TestClass]
	public class PlayersSortTests : ClientTestsBase
	{
		
		private PlayersClient GetClient()
		{
			return new PlayersClient(GetApiKey());
		}

		[TestMethod]
		public void SortByCflCentralIdTest()
		{
			var client = GetClient();

			//var options = new PlayersRequestOptions {  Sorts = new [] { }}
		}
	}
}
