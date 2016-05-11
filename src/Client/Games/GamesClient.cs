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

		public IEnumerable<Game> GetGames(int pageNumber, int pageSize, params GameFilter[] filters)
		{
			const string path = "/v1/games";

			var url = GetUrl(path);

			AppendFilters(ref url, filters);
			AppendParameter(ref url, $"page[number]={pageNumber}");
			AppendParameter(ref url, $"page[size]={pageSize}");


			return GetResponse<GamesContainer>(url).Data;
		}

		public IEnumerable<Game> GetGames(int season, params GameFilter[] filters)
		{
			var path = $"/v1/games/{season}";
			var url = GetUrl(path);
			AppendFilters(ref url, filters);

			return GetResponse<GamesContainer>(url).Data;
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


			var response = GetResponse<GamesContainer>(url).Data;

			return response[0];
		}

	}
}
