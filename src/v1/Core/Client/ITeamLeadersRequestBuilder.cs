namespace mdryden.cflapi.v1.Client
{
	public interface ITeamLeadersRequestBuilder<TRequestBuilder, TResponse> : IRequestBuilder<TResponse>
	{
		TRequestBuilder Season(int season);
	}
}
