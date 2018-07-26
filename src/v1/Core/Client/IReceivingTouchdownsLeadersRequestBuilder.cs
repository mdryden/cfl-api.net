using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IReceivingTouchdownsLeadersRequestBuilder : ILeadersRequestBuilder<IReceivingTouchdownsLeadersRequestBuilder, IList<PlayerReceivingTouchdowns>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IReceivingTouchdownsLeadersRequestBuilder>>
	{

	}
}
