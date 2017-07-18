using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class ReceivingTouchdownsLeadersRequestBuilder : LeadersRequestBuilder<IReceivingTouchdownsLeadersRequestBuilder, IList<PlayerReceivingYards>>, IReceivingTouchdownsLeadersRequestBuilder
	{
		public ReceivingTouchdownsLeadersRequestBuilder(int season)
			: base("receiving_touchdowns", season)
		{

		}
	}
}
