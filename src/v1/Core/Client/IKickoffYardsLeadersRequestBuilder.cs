using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IKickoffYardsLeadersRequestBuilder : ILeadersRequestBuilder<IKickoffYardsLeadersRequestBuilder, IList<PlayerKickoffYards>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IKickoffYardsLeadersRequestBuilder>>
	{

	}
}
