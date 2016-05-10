using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models;
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





		public IEnumerable<Game> GetGames(params GameFilter[] filters)
		{
			const int defaultPage = 1;
			const int defaultSize = 20;

			return GetGames(defaultPage, defaultSize, filters);
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

		public string GetGameUrl(int season, int gameId, bool includeBoxscore, bool includePlayByPlay)
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

			return url;
		}

		public Game GetGame(int season, int gameId, bool includeBoxscore, bool includePlayByPlay)
		{
			var url = GetGameUrl(season, gameId, includeBoxscore, includePlayByPlay);
			var response = GetResponse<GamesContainer>(url).Data;

			return response[0];
		}

		public IEnumerable<Player> GetPlayers()
		{
			throw new NotImplementedException();

		}

		public Player GetPlayer(int cflCentralId)
		{
			throw new NotImplementedException();

		}
	}
}
