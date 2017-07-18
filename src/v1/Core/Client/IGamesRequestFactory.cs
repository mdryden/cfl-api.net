namespace mdryden.cflapi.v1.Client
{
	public interface IGamesRequestFactory
	{
		IGameRequestBuilder GetGame(int season, int gameId);
		IGamesRequestBuilder GetGames();
	}
}