namespace mdryden.cflapi.v1.Client
{
	public interface IFluentFilterCreator<TValue, TOptions, TAdditionalFluentRequestOptionsType> where TOptions : IFilteredRequestOptions, TAdditionalFluentRequestOptionsType
	{

	}

	public interface IFluentFilterCreator<TValue>
	{

	}
}
