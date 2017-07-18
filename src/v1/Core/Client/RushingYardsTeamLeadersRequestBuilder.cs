using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public class RushingYardsTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<IRushingYardsTeamLeadersRequestBuilder, TeamRushingYards>, IRushingYardsTeamLeadersRequestBuilder
	{
		public RushingYardsTeamLeadersRequestBuilder(int season)
			: base("rushing_yards", season)
		{

		}
	}
}
