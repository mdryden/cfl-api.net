using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class PassingTouchdownsLeadersRequestBuilder : LeadersRequestBuilder<IPassingTouchdownsLeadersRequestBuilder, IList<PlayerPassingTouchdowns>>, IPassingTouchdownsLeadersRequestBuilder
	{
		public PassingTouchdownsLeadersRequestBuilder(int season)
			: base("passing_touchdowns", season)
		{

		}
	}
}
