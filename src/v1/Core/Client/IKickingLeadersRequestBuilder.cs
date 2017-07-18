using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IKickingLeadersRequestBuilder : ILeadersRequestBuilder<IKickingLeadersRequestBuilder, IList<PlayerKicking>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IKickingLeadersRequestBuilder>>,
		IExtendedDataAvailable<IKickingLeadersRequestBuilder>
	{

	}
}
