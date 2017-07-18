using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class InterceptionsLeadersRequestBuilder : LeadersRequestBuilder<IInterceptionsLeadersRequestBuilder, IList<Offence>>, IInterceptionsLeadersRequestBuilder
	{
		public InterceptionsLeadersRequestBuilder(int season)
			: base("interceptions", season)
		{

		}
	}
}
