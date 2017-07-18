using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IReceivingYardsLeadersRequestBuilder : ILeadersRequestBuilder<IReceivingYardsLeadersRequestBuilder, IList<PlayerReceivingYards>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IReceivingYardsLeadersRequestBuilder>>,
		IExtendedDataAvailable<IReceivingYardsLeadersRequestBuilder>
	{

	}
}
