using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class RushingTouchdownsLeadersRequestBuilder : LeadersRequestBuilder<IRushingTouchdownsLeadersRequestBuilder, IList<PlayerRushingTouchdowns>>, IRushingTouchdownsLeadersRequestBuilder
	{
		public RushingTouchdownsLeadersRequestBuilder(int season)
			: base("rushing_touchdowns", season)
		{

		}
	}
}
