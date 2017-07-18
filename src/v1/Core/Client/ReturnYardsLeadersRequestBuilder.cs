using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class ReturnYardsLeadersRequestBuilder : LeadersRequestBuilder<IReturnYardsLeadersRequestBuilder, IList<PlayerReturnYards>>, IReturnYardsLeadersRequestBuilder
	{
		public ReturnYardsLeadersRequestBuilder(int season)
			: base("return_yards", season)
		{

		}
	}
}
