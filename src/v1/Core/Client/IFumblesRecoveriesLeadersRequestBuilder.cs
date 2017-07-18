using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IFumblesRecoveriesLeadersRequestBuilder : ILeadersRequestBuilder<IFumblesRecoveriesLeadersRequestBuilder, IList<PlayerFumblesRecoveries>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IFumblesRecoveriesLeadersRequestBuilder>>
	{

	}
}
