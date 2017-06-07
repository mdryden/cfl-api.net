namespace mdryden.cflapi.v1.Client
{
	public interface IFluentSortCreator<TOptions, TAdditionalFluentRequestOptionsType> where TOptions : ISortedRequestOptions, TAdditionalFluentRequestOptionsType
	{
		TAdditionalFluentRequestOptionsType Ascending();
		TAdditionalFluentRequestOptionsType Descending();
	}
}
