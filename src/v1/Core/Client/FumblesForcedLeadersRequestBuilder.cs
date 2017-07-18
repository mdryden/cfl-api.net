using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class FumblesForcedLeadersRequestBuilder : LeadersRequestBuilder<IFumblesForcedLeadersRequestBuilder, IList<PlayerFumblesForced>>, IFumblesForcedLeadersRequestBuilder
	{
		public FumblesForcedLeadersRequestBuilder(int season)
			: base("fumbles_forced", season)
		{

		}
	}
}
