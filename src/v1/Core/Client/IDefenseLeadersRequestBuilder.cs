using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IDefenceLeadersRequestBuilder : ILeadersRequestBuilder<IDefenceLeadersRequestBuilder, IList<Defence>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IDefenceLeadersRequestBuilder>>,
		IExtendedDataAvailable<IDefenceLeadersRequestBuilder>
	{

	}
	public class DefenceLeadersRequestBuilder : LeadersRequestBuilder<IDefenceLeadersRequestBuilder, IList<Defence>>, IDefenceLeadersRequestBuilder
	{
		public DefenceLeadersRequestBuilder(int season)
			: base("defence", season)
		{

		}
	}
}
