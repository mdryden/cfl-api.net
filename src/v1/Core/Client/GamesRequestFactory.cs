namespace mdryden.cflapi.v1.Client
{
	public class GamesRequestFactory : IGamesRequestFactory
	{
		public static IGamesRequestBuilder GamesRequestBuilder { get; set; }
		public static IGameRequestBuilder GameRequestBuilder { get; set; }

		public IGamesRequestBuilder GetGames()
		{
			return GamesRequestBuilder ?? new GamesRequestBuilder();
		}

		public IGameRequestBuilder GetGame(int season, int gameId)
		{
			return GameRequestBuilder ?? new GameRequestBuilder(season, gameId);
		}
	}
}
