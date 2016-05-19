using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models.Games;

namespace mdryden.cflapi.v1.Client.Games
{
	public class GamesClient : ClientBase
	{

		public GamesClient(string apiKey)
			: base(apiKey)
		{

		}


		public IList<Game> GetGames(int pageNumber, int pageSize)
		{
			return GetGames(pageNumber, pageSize, new GamesRequestOptions());
		}

		private void SetIds(IEnumerable<Game> games)
		{
			var idSetter = new IdSetter();

			idSetter.SetIds(games);
		}

		public IList<Game> GetGames(int pageNumber, int pageSize, GamesRequestOptions options)
		{
			const string path = "/v1/games";

			var url = GetUrl(path);

			AppendFilters(ref url, options.Filters);
			AppendSorts(ref url, options.Sorts);
			AppendParameter(ref url, $"page[number]={pageNumber}");
			AppendParameter(ref url, $"page[size]={pageSize}");


			var games = GetCollectionResponse<Game>(url);

			SetIds(games);

			return games;
		}

		public IList<Game> GetGames(int season)
		{
			return GetGames(season, new GamesRequestOptions());
		}

		public IList<Game> GetGames(int season, GamesRequestOptions options)
		{
			var path = $"/v1/games/{season}";
			var url = GetUrl(path);
			AppendFilters(ref url, options.Filters);
			AppendSorts(ref url, options.Sorts);

			var games = GetCollectionResponse<Game>(url);

			SetIds(games);

			return games;
		}

		public Game GetGame(int season, int gameId, bool includeBoxscore, bool includePlayByPlay)
		{
			var path = $"/v1/games/{season}/game/{gameId}";
			var url = GetUrl(path);

			var includes = new List<string>();
			if (includeBoxscore)
			{
				includes.Add("boxscore");
			}

			if (includePlayByPlay)
			{
				includes.Add("play_by_play");
			}

			if (includes.Count > 0)
			{
				var includesString = $"include={string.Join(",", includes)}";
				AppendParameter(ref url, includesString);
			}
			
			var game = GetItemResponse<Game>(url);

			var idSetter = new IdSetter();

			idSetter.SetIds(game);

			return game;
		}

	}
}
