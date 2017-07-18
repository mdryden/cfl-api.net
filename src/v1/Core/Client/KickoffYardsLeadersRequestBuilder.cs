using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class KickoffYardsLeadersRequestBuilder : LeadersRequestBuilder<IKickoffYardsLeadersRequestBuilder, IList<PlayerKickoffYards>>, IKickoffYardsLeadersRequestBuilder
	{
		public KickoffYardsLeadersRequestBuilder(int season)
			: base("kickoff_yards", season)
		{

		}
	}
}
