namespace mdryden.cflapi.v1.Client
{
	public interface ILeadersFilterFactoryFactory
	{
		ILeadersFilterFactory<TRequestBuilder> GetFilterFactory<TRequestBuilder>(TRequestBuilder request) where TRequestBuilder : IFilteredRequest;
	}
}