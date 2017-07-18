using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{

	public interface IConvert1LeadersRequestBuilder : ILeadersRequestBuilder<IConvert1LeadersRequestBuilder, IList<PlayerConverts1>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IConvert1LeadersRequestBuilder>>
	{

	}
	public class Convert1LeadersRequestBuilder : LeadersRequestBuilder<IConvert1LeadersRequestBuilder, IList<PlayerConverts1>>, IConvert1LeadersRequestBuilder
	{

		public Convert1LeadersRequestBuilder(int season)
			: base("converts", season)
		{

		}
		
	}
}
