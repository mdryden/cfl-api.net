﻿using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IFumblesForcedLeadersRequestBuilder : ILeadersRequestBuilder<IFumblesForcedLeadersRequestBuilder, IList<PlayerFumblesForced>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IFumblesForcedLeadersRequestBuilder>>
	{

	}
}
