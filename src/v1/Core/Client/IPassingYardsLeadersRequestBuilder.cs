using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IPassingYardsLeadersRequestBuilder : ILeadersRequestBuilder<IPassingYardsLeadersRequestBuilder, IList<PlayerPassingYards>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IPassingYardsLeadersRequestBuilder>>
	{

	}
}
