using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IReceivingCaughtLeadersRequestBuilder : ILeadersRequestBuilder<IReceivingCaughtLeadersRequestBuilder, IList<PlayerReceivingCaught>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IReceivingCaughtLeadersRequestBuilder>>
	{

	}

}
