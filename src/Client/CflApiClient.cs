using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using mdryden.cflapi.v1.Models.Players;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Client
{
	public class CflApiClient
	{
		private string apiKey;
		private string host;

		public CflApiClient(string apiKey, string host = "http://api.cfl.ca")
		{
			this.apiKey = apiKey;
			this.host = host;
		}

		private string GetUrl(string path)
		{
			return $"{host}{path}?key={apiKey}";			
        }

		private void AppendFilters(ref string url, IEnumerable<Filter> filters)
		{
			foreach (var filter in filters)
			{
				url += $"&{filter.GetFilterString()}";				
			}
		}

		private void AppendParameter(ref string url, string parameter)
		{
			url += $"&{parameter}";
		}
		
		public T GetResponse<T>(string url)
		{
			string response;

			using (var client = new WebClient())
			{
				response = client.DownloadString(url);
			}

			return JsonConvert.DeserializeObject<T>(response);
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

		public IEnumerable<Player> GetPlayers(int pageNumber, int pageSize, params PlayerFilter[] filters)
		{
			const string path = "/v1/players";

			var url = GetUrl(path);
			AppendFilters(ref url, filters);
			AppendParameter(ref url, $"page[number]={pageNumber}");
			AppendParameter(ref url, $"page[size]={pageSize}");

			return GetResponse<PlayersContainer>(url).Data;
		}

		public Player GetPlayer(int cflCentralId, bool includeSeasons, bool includeGameByGame)
		{
			var path = $"/v1/players/{cflCentralId}";

			var url = GetUrl(path);

			var includes = new List<string>();
			if (includeSeasons)
			{
				includes.Add("seasons");
			}

			if (includeGameByGame)
			{
				includes.Add("game_by_game");
			}

			if (includes.Count > 0)
			{
				var includesString = $"include={string.Join(",", includes)}";
				AppendParameter(ref url, includesString);
			}

			var response = GetResponse<PlayersContainer>(url).Data;

			return response[0];

		}
	}
}
