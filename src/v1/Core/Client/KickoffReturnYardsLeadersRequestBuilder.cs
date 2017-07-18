using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class KickoffReturnYardsLeadersRequestBuilder : LeadersRequestBuilder<IKickoffReturnYardsLeadersRequestBuilder, IList<PlayerKickoffReturnYards>>, IKickoffReturnYardsLeadersRequestBuilder
	{
		public KickoffReturnYardsLeadersRequestBuilder(int season)
			: base("kickoff_return_yards", season)
		{

		}
	}
}
