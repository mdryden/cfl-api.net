using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface ITeamLeadersRequestBuilder<TRequestBuilder, TResponse> : IRequestBuilder<IList<TResponse>>
	{
		TRequestBuilder Season(int season);
	}
}
