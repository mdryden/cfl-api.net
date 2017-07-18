using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class RushingYardsLeadersRequestBuilder : LeadersRequestBuilder<IRushingYardsLeadersRequestBuilder, IList<PlayerRushingYards>>, IRushingYardsLeadersRequestBuilder
	{
		public RushingYardsLeadersRequestBuilder(int season)
			: base("rushing_yards", season)
		{

		}
	}
}
