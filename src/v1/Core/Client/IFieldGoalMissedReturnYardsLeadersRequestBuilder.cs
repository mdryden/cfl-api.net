using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IFieldGoalMissedReturnYardsLeadersRequestBuilder : ILeadersRequestBuilder<IFieldGoalMissedReturnYardsLeadersRequestBuilder, IList<PlayerFieldGoalMissedReturnYards>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IFieldGoalMissedReturnYardsLeadersRequestBuilder>>
	{

	}
}
