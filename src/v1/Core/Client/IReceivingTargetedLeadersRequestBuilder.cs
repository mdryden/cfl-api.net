using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IReceivingTargetedLeadersRequestBuilder : ILeadersRequestBuilder<IReceivingTargetedLeadersRequestBuilder, IList<PlayerReceivingTargeted>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IReceivingTargetedLeadersRequestBuilder>>
	{

	}
}
