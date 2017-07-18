using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{

	public interface ITotalYardsTeamLeadersRequestBuilder : ITeamLeadersRequestBuilder<ITotalYardsTeamLeadersRequestBuilder, TeamTotalYards>,
		IFilteredRequest
	{

	}
}
