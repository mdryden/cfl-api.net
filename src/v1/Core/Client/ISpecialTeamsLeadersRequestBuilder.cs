﻿using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface ISpecialTeamsLeadersRequestBuilder : ILeadersRequestBuilder<ISpecialTeamsLeadersRequestBuilder, IList<SpecialTeams>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<ISpecialTeamsLeadersRequestBuilder>>,
		IExtendedDataAvailable<ISpecialTeamsLeadersRequestBuilder>
	{

	}
}
