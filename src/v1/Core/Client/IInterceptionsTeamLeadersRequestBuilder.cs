using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{
	public interface IInterceptionsTeamLeadersRequestBuilder : ITeamLeadersRequestBuilder<IInterceptionsTeamLeadersRequestBuilder, TeamInterceptions>,
		IFilteredRequest
	{

	}
}
