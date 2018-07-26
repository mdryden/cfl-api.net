using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{

	public interface IConvert2LeadersRequestBuilder : ILeadersRequestBuilder<IConvert2LeadersRequestBuilder, IList<PlayerConverts2>>,
		IFilteredRequest,
		IFluentFilters<ILeadersFilterFactory<IConvert2LeadersRequestBuilder>>
	{

	}

	public class Convert2LeadersRequestBuilder : LeadersRequestBuilder<IConvert2LeadersRequestBuilder, IList<PlayerConverts2>>, IConvert2LeadersRequestBuilder
	{
		public Convert2LeadersRequestBuilder(int season)
			: base("converts", season)
		{

		}

	}
}
