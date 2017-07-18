using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface ITacklesDefensiveLeadersRequestBuilder : ILeadersRequestBuilder<ITacklesDefensiveLeadersRequestBuilder, IList<PlayerTacklesDefensive>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<ITacklesDefensiveLeadersRequestBuilder>>
	{

	}
}
