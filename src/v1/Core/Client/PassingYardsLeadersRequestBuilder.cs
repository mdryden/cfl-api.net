using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class PassingYardsLeadersRequestBuilder : LeadersRequestBuilder<IPassingYardsLeadersRequestBuilder, IList<PlayerPassingYards>>, IPassingYardsLeadersRequestBuilder
	{
		public PassingYardsLeadersRequestBuilder(int season)
			: base("passing_yards", season)
		{

		}
	}
}
