using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IPassingTouchdownsLeadersRequestBuilder : ILeadersRequestBuilder<IPassingTouchdownsLeadersRequestBuilder, IList<PlayerPassingTouchdowns>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IPassingTouchdownsLeadersRequestBuilder>>
	{

	}
}
