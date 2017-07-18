using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public class TotalYardsTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<ITotalYardsTeamLeadersRequestBuilder, TeamTotalYards>, ITotalYardsTeamLeadersRequestBuilder
	{
		public TotalYardsTeamLeadersRequestBuilder(int season)
			: base("total_yards", season)
		{

		}
	}
}
