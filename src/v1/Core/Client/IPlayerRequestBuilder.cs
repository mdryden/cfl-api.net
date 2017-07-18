using mdryden.cflapi.v1.Models.Players;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IPlayerRequestBuilder : IRequestBuilder<Player, IList<Player>>
	{
		IPlayerRequestBuilder CflCentralId(int cflCentralId);
		IPlayerRequestBuilder WithSeasons();
		IPlayerRequestBuilder WithGameByGame();
		IPlayerRequestBuilder WithCurrentTeam();
	}
}
