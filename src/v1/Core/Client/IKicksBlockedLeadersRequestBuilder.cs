using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;
using System;

namespace mdryden.cflapi.v1.Client
{
	public interface IKicksBlockedLeadersRequestBuilder : ILeadersRequestBuilder<IKicksBlockedLeadersRequestBuilder, IList<PlayerKicksBlocked>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IKicksBlockedLeadersRequestBuilder>>
	{

	}

	public class KicksBlockedLeadersRequestBuilder : LeadersRequestBuilder<IKicksBlockedLeadersRequestBuilder, IList<PlayerKicksBlocked>>, IKicksBlockedLeadersRequestBuilder
	{
		public KicksBlockedLeadersRequestBuilder(int season)
			: base("kicks_blocked", season)
		{

		}
		
	}
}
