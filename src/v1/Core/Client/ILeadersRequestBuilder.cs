namespace mdryden.cflapi.v1.Client
{
	public interface ILeadersRequestBuilder<TRequestBuilder, TResponse> : IRequestBuilder<TResponse>
	{
		TRequestBuilder Season(int season);
	}
}
