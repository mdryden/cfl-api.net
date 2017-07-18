using mdryden.cflapi.v1.Models.Players;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IPlayersRequestBuilder : IRequestBuilder<IList<Player>>,
		IPagedRequest<IPlayersRequestBuilder>,
		IFilteredRequest,
		ISortedRequest,
		IFluentFilters<IPlayersFilterFactory<IPlayersRequestBuilder>>,
		IFluentSorts<IPlayersSortFactory<IPlayersRequestBuilder>>
	{
		IPlayersRequestBuilder WithCurrentTeam();
	}
}
