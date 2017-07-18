using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface ISacksLeadersRequestBuilder : ILeadersRequestBuilder<ISacksLeadersRequestBuilder, IList<PlayerSacks>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<ISacksLeadersRequestBuilder>>
	{

	}
}
