using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class KickingLeadersRequestBuilder : LeadersRequestBuilder<IKickingLeadersRequestBuilder, IList<PlayerKicking>>, IKickingLeadersRequestBuilder
	{
		public KickingLeadersRequestBuilder(int season)
			: base("kicking", season)
		{

		}
	}
}
