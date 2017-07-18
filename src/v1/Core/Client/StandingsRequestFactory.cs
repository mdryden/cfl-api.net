namespace mdryden.cflapi.v1.Client
{
	public class StandingsRequestFactory : IStandingsRequestFactory
	{
		public static IStandingsRequestBuilder StandingsRequestBuilder { get; set; }
		public static ICrossoverStandingsRequestBuilder CrossoverStandingsRequestBuilder { get; set; }
		
		public IStandingsRequestBuilder GetStandings(int season)
		{
			return StandingsRequestBuilder ?? new StandingsRequestBuilder(season);
		}

		public ICrossoverStandingsRequestBuilder GetCrossoverStandings(int season)
		{
			return CrossoverStandingsRequestBuilder ?? new CrossoverStandingsRequestBuilder(season);
		}
	}
}
