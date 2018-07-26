using mdryden.cflapi.v1.Models.Standings;

namespace mdryden.cflapi.v1.Client
{
	public interface ICrossoverStandingsRequestBuilder : IRequestBuilder<CrossoverStandings>
	{
		ICrossoverStandingsRequestBuilder Season(int season);
	}
}