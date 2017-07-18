using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public class PassingTouchdownsTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<IPassingTouchdownsTeamLeadersRequestBuilder, TeamPassingTouchdowns>, IPassingTouchdownsTeamLeadersRequestBuilder
	{
		public PassingTouchdownsTeamLeadersRequestBuilder(int season)
			: base("passing_touchdowns", season)
		{

		}
	}
}
