using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class SacksLeadersRequestBuilder : LeadersRequestBuilder<ISacksLeadersRequestBuilder, IList<PlayerSacks>>, ISacksLeadersRequestBuilder
	{
		public SacksLeadersRequestBuilder(int season)
			: base("sacks", season)
		{

		}
	}
}
