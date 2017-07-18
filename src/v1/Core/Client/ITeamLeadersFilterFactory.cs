using System;

namespace mdryden.cflapi.v1.Client
{
	public interface ITeamLeadersFilterFactory<TRequestBuilder> where TRequestBuilder : IFilteredRequest
	{
		TRequestBuilder TeamId(TeamLeadersFilterOperators @operator, int value);
		TRequestBuilder EndDate(TeamLeadersFilterOperators @operator, DateTime value);
		TRequestBuilder Week(TeamLeadersFilterOperators @operator, int value);
	}
	
}
