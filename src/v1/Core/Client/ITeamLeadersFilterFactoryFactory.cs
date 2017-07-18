namespace mdryden.cflapi.v1.Client
{
	public interface ITeamLeadersFilterFactoryFactory
	{
		ITeamLeadersFilterFactory<TRequestBuilder> GetFilterFactory<TRequestBuilder>(TRequestBuilder request) where TRequestBuilder : IFilteredRequest;
	}
}
