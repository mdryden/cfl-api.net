using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IReturnsLeadersRequestBuilder : ILeadersRequestBuilder<IReturnsLeadersRequestBuilder, IList<PlayerReturns>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IReturnsLeadersRequestBuilder>>,
		IExtendedDataAvailable<IReturnsLeadersRequestBuilder>
	{

	}
}
