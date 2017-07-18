using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IKickoffReturnYardsLeadersRequestBuilder : ILeadersRequestBuilder<IKickoffReturnYardsLeadersRequestBuilder, IList<PlayerKickoffReturnYards>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IKickoffReturnYardsLeadersRequestBuilder>>
	{

	}
}
