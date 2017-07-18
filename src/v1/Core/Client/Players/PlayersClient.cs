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

		public IEnumerable<Player> GetPlayers(int pageNumber = 1, int? pageSize = null, PlayersRequestOptions options  = null)
		{
			const string path = "/v1/players";

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

			var players = GetCollectionResponse<Player>(url);

			var idSetter = new IdSetter();

			idSetter.SetIds(players);

			return players;
		}

		public Player GetPlayer(int cflCentralId, bool includeSeasons = false, bool includeGameByGame = false)
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

			var player = GetFirstItemResponse<Player>(url);

			var idSetter = new IdSetter();

			idSetter.SetIds(player);

			return player;

		}
	}
}
