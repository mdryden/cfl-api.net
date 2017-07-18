using System;

namespace mdryden.cflapi.v1.Client
{
	public interface ILeadersFilterFactory<TRequest> where TRequest : IFilteredRequest
	{
		TRequest EndDate(LeadersFilterOperators @operator, DateTime value);
		TRequest TeamId(LeadersFilterOperators @operator, int value);
	}
}