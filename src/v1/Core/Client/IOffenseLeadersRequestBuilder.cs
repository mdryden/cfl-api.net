using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IOffenceLeadersRequestBuilder : ILeadersRequestBuilder<IOffenceLeadersRequestBuilder, IList<Offence>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IOffenceLeadersRequestBuilder>>,
		IExtendedDataAvailable<IOffenceLeadersRequestBuilder>
	{

	}
}
