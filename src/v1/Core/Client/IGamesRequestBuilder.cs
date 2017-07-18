using mdryden.cflapi.v1.Models.Games;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IGamesRequestBuilder : IRequestBuilder<IList<Game>>,
		IPagedRequest<IGamesRequestBuilder>, 
		IFilteredRequest,
		IFluentFilters<GamesFilterFactory<IGamesRequestBuilder>>,
		ISortedRequest,
		IFluentSorts<GamesSortFactory<IGamesRequestBuilder>>
	{
		IGamesRequestBuilder Season(int season);
	}
}
