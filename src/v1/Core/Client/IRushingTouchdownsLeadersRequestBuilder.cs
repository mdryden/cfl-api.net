using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IRushingTouchdownsLeadersRequestBuilder : ILeadersRequestBuilder<IRushingTouchdownsLeadersRequestBuilder, IList<PlayerRushingTouchdowns>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IRushingTouchdownsLeadersRequestBuilder>>
	{

	}
}
