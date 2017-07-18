namespace mdryden.cflapi.v1.Client
{
	public class TeamLeadersFilterFactoryFactory : ITeamLeadersFilterFactoryFactory
	{
		public ITeamLeadersFilterFactory<TRequest> GetFilterFactory<TRequest>(TRequest request)
			where TRequest : IFilteredRequest
		{
			return new TeamLeadersFilterFactory<TRequest>(request);
		}
	}
}
