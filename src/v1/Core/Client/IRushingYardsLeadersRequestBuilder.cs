using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IRushingYardsLeadersRequestBuilder : ILeadersRequestBuilder<IRushingYardsLeadersRequestBuilder, IList<PlayerRushingYards>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IRushingYardsLeadersRequestBuilder>>,
		IExtendedDataAvailable<IRushingYardsLeadersRequestBuilder>
	{

	}
}
