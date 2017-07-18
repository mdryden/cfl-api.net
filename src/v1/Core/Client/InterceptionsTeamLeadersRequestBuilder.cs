using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public class InterceptionsTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<IInterceptionsTeamLeadersRequestBuilder, TeamInterceptions>, IInterceptionsTeamLeadersRequestBuilder
	{
		public InterceptionsTeamLeadersRequestBuilder(int season)
			: base("interceptions", season)
		{

		}
	}
}
