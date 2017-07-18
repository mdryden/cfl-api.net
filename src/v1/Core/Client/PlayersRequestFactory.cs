using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class PlayersRequestFactory : IPlayersRequestFactory
	{

		public static IPlayersRequestBuilder PlayersRequestBuilder { get; set; } = new PlayersRequestBuilder();
		public static IPlayerRequestBuilder PlayerRequestBuilder { get; set; }

		public IPlayersRequestBuilder GetPlayers()
		{
			return PlayersRequestBuilder;
		}
		public IPlayerRequestBuilder GetPlayer(int cflCentralId)
		{
			return PlayerRequestBuilder ?? new PlayerRequestBuilder(cflCentralId);
		}

	}
}
