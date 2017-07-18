namespace mdryden.cflapi.v1.Client
{
	public interface IStandingsRequestFactory
	{
		ICrossoverStandingsRequestBuilder GetCrossoverStandings(int season);
		IStandingsRequestBuilder GetStandings(int season);
	}
}