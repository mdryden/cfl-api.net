using mdryden.cflapi.v1.Models.Standings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Standings
{
	public class StandingsClient : ClientBase
	{
		public StandingsClient(string apiKey, string host = "http://api.cfl.ca") 
			: base(apiKey, host)
		{
		}

		public SeasonStandings GetStandings(int season)
		{
			var path = $"/v1/standings/{season}";

			var url = GetUrl(path);

			var container = GetItemResponse<SeasonContainer>(url);

			return container.Standings;
		}

		public CrossoverStandings GetCrossoverStandings(int season)
		{
			var path = $"/v1/standings/crossover/{season}";

			var url = GetUrl(path);

			var container = GetItemResponse<CrossoverContainer>(url);

			return container.Standings;
		}

	}
}
