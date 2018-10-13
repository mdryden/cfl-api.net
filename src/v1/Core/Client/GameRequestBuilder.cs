using mdryden.cflapi.v1.Models.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class GameRequestBuilder : RequestBuilder<Game, IList<Game>>, IGameRequestBuilder
	{
		private int season;
		private int gameId;

		public GameRequestBuilder(int season, int gameId)
		{
			this.season = season;
			this.gameId = gameId;
		}

		protected override string GetPath()
		{
			return $"/v1/games/{season}/game/{gameId}";
		}

		public IGameRequestBuilder Season(int season)
		{
			this.season = season;
			return this;
		}

		public IGameRequestBuilder GameId(int gameId)
		{
			this.gameId = gameId;
			return this;
		}

		public IGameRequestBuilder WithBoxscore()
		{
			Includes.Add("boxscore");
			return this;
		}

		public IGameRequestBuilder WithPlayByPlay()
		{
			Includes.Add("play_by_play");
			return this;
		}

		public IGameRequestBuilder WithRosters()
		{
			Includes.Add("rosters");
			return this;
		}

		public IGameRequestBuilder WithPenalties()
		{
			Includes.Add("penalties");
			return this;
		}

		public override Game CleanResponse(IList<Game> games)
		{
			return games.FirstOrDefault();
		}
	}
}
