using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IReturnYardsLeadersRequestBuilder : ILeadersRequestBuilder<IReturnYardsLeadersRequestBuilder, IList<PlayerReturnYards>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IReturnYardsLeadersRequestBuilder>>
	{

	}
}
