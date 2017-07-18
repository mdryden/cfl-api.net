using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface ITacklesSpecialTeamsLeadersRequestBuilder : ILeadersRequestBuilder<ITacklesSpecialTeamsLeadersRequestBuilder, IList<PlayerTacklesSpecialTeams>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<ITacklesSpecialTeamsLeadersRequestBuilder>>
	{

	}
}
