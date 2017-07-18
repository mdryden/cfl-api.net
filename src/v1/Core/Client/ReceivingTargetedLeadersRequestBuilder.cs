using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class ReceivingTargetedLeadersRequestBuilder : LeadersRequestBuilder<IReceivingTargetedLeadersRequestBuilder, IList<PlayerReceivingTargeted>>, IReceivingTargetedLeadersRequestBuilder
	{
		public ReceivingTargetedLeadersRequestBuilder(int season)
			: base("receiving_targeted", season)
		{

		}
	}
}
