namespace mdryden.cflapi.v1.Client
{
	public class LeadersFilterFactoryFactory : ILeadersFilterFactoryFactory
	{
		public ILeadersFilterFactory<TRequest> GetFilterFactory<TRequest>(TRequest request)
			where TRequest : IFilteredRequest
		{
			return new LeadersFilterFactory<TRequest>(request);
		}
	}
}
