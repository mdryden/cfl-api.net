namespace mdryden.cflapi.v1.Client
{
	public interface IRequestBuilder<TResponse, TApiResponse>
	{
		Request<TResponse, TApiResponse> GetRequest();
		TResponse CleanResponse(TApiResponse response);
	}

	public interface IRequestBuilder<TResponse> : IRequestBuilder<TResponse, TResponse>
	{ }
}