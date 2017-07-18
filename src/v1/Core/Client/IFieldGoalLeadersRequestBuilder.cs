using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IFieldGoalsLeadersRequestBuilder : ILeadersRequestBuilder<IFieldGoalsLeadersRequestBuilder, IList<PlayerFieldGoals>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IFieldGoalsLeadersRequestBuilder>>,
		IExtendedDataAvailable<IFieldGoalsLeadersRequestBuilder>
	{

	}
}
