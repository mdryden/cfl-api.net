using mdryden.cflapi.v1.Models.Games;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public interface IGameRequestBuilder : IRequestBuilder<Game, IList<Game>>
	{
		IGameRequestBuilder Season(int season);
		IGameRequestBuilder GameId(int gameId);
		IGameRequestBuilder WithBoxscore();
		IGameRequestBuilder WithPlayByPlay();
		IGameRequestBuilder WithRosters();
		IGameRequestBuilder WithPenalties();
		IGameRequestBuilder WithPlayReviews();
	}
}