using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class ReturnsLeadersRequestBuilder : LeadersRequestBuilder<IReturnsLeadersRequestBuilder, IList<PlayerReturns>>, IReturnsLeadersRequestBuilder
	{
		public ReturnsLeadersRequestBuilder(int season)
			: base("returns", season)
		{

		}
	}
}
