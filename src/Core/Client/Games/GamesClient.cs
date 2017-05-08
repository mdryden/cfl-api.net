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

		private void SetIds(IEnumerable<Game> games)
		{
			var idSetter = new IdSetter();

			idSetter.SetIds(games);
		}
		

		public IList<Game> GetGames(int? season = null, int pageNumber = 1, int? pageSize = null, GamesRequestOptions options = null)
		{
			var path = season != null ? $"/v1/games/{season}" : "/v1/games";

			var url = GetUrl(path);

			if (options != null)
			{
				AppendFilters(ref url, options.Filters);
				AppendSorts(ref url, options.Sorts);
			}

			AppendParameter(ref url, $"page[number]={pageNumber}");

			if (pageSize != null)
			{
				AppendParameter(ref url, $"page[size]={pageSize}");
			}


			var games = GetCollectionResponse<Game>(url);

			SetIds(games);

			return games;
		}


		public Game GetGame(int season, int gameId, bool includeBoxscore = false, bool includePlayByPlay = false, bool includeRosters = false)
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

			if (includeRosters)
			{
				includes.Add("rosters");
			}

			if (includes.Count > 0)
			{
				var includesString = $"include={string.Join(",", includes)}";
				AppendParameter(ref url, includesString);
			}

			var game = GetFirstItemResponse<Game>(url);

			var idSetter = new IdSetter();

			idSetter.SetIds(game);

			return game;
		}
	}
}
