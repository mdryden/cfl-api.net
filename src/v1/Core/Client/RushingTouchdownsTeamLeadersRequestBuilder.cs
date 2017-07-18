using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public class RushingTouchdownsTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<IRushingTouchdownsTeamLeadersRequestBuilder, TeamRushingTouchdowns>, IRushingTouchdownsTeamLeadersRequestBuilder
	{
		public RushingTouchdownsTeamLeadersRequestBuilder(int season)
			: base("rushing_touchdowns", season)
		{

		}
	}
}
