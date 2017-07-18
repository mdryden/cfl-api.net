using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class ReceivingCaughtLeadersRequestBuilder : LeadersRequestBuilder<IReceivingCaughtLeadersRequestBuilder, IList<PlayerReceivingCaught>>, IReceivingCaughtLeadersRequestBuilder
	{
		public ReceivingCaughtLeadersRequestBuilder(int season)
			: base("receiving_caught", season)
		{

		}
	}

}
