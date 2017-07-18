using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class ReceivingYardsLeadersRequestBuilder : LeadersRequestBuilder<IReceivingYardsLeadersRequestBuilder, IList<PlayerReceivingYards>>, IReceivingYardsLeadersRequestBuilder
	{
		public ReceivingYardsLeadersRequestBuilder(int season)
			: base("receiving_yards", season)
		{

		}
	}
}
