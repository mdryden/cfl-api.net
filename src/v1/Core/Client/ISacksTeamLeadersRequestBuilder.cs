using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{

	public interface ISacksTeamLeadersRequestBuilder : ITeamLeadersRequestBuilder<ISacksTeamLeadersRequestBuilder, TeamSacks>,
		IFilteredRequest
	{

	}

	public class SacksTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<ISacksTeamLeadersRequestBuilder, TeamSacks>, ISacksTeamLeadersRequestBuilder
	{
		public SacksTeamLeadersRequestBuilder(int season)
			: base("sacks", season)
		{

		}
	}
}
