using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public class PassingYardsTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<IPassingYardsTeamLeadersRequestBuilder, TeamPassingYards>, IPassingYardsTeamLeadersRequestBuilder
	{
		public PassingYardsTeamLeadersRequestBuilder(int season)
			: base("passing_yards", season)
		{

		}
	}
}
