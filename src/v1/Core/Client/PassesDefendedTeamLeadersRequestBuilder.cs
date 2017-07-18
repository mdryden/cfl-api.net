using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public class PassesDefendedTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<IPassesDefendedTeamLeadersRequestBuilder, TeamPassesDefended>, IPassesDefendedTeamLeadersRequestBuilder
	{
		public PassesDefendedTeamLeadersRequestBuilder(int season)
			: base("passes_defended", season)
		{

		}
	}
}
