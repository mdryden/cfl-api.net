using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public class FumblesForcedTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<IFumblesForcedTeamLeadersRequestBuilder, TeamFumblesForced>, IFumblesForcedTeamLeadersRequestBuilder
	{
		public FumblesForcedTeamLeadersRequestBuilder(int season)
			: base("fumbles_forced", season)
		{

		}
	}
}
