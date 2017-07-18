using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class TacklesDefensiveLeadersRequestBuilder : LeadersRequestBuilder<ITacklesDefensiveLeadersRequestBuilder, IList<PlayerTacklesDefensive>>, ITacklesDefensiveLeadersRequestBuilder
	{
		public TacklesDefensiveLeadersRequestBuilder(int season)
			: base("tackles_defensive", season)
		{

		}
	}
}
