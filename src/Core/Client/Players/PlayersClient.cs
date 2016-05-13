using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models.Players;

namespace mdryden.cflapi.v1.Client.Players
{
	public class PlayersClient : ClientBase
	{
		public PlayersClient(string apiKey)
			: base(apiKey)
		{

		}

		public IEnumerable<Player> GetPlayers(int pageNumber, int pageSize)
		{
			return GetPlayers(pageNumber, pageSize, new PlayersRequestOptions());
		}

		public IEnumerable<Player> GetPlayers(int pageNumber, int pageSize, PlayersRequestOptions options)
		{
			const string path = "/v1/players";

			var url = GetUrl(path);
			AppendFilters(ref url, options.Filters);
			AppendSorts(ref url, options.Sorts);
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
