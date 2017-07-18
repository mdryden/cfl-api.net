using mdryden.cflapi.v1.Models.Standings;

namespace mdryden.cflapi.v1.Client
{
	public interface IStandingsRequestBuilder : IRequestBuilder<SeasonStandings>
	{
		IStandingsRequestBuilder Season(int season);
	}
}