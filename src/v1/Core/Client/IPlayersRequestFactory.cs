namespace mdryden.cflapi.v1.Client
{
	public interface IPlayersRequestFactory
	{
		IPlayerRequestBuilder GetPlayer(int cflCentralId);
		IPlayersRequestBuilder GetPlayers();
	}
}