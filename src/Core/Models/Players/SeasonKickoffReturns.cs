using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class SeasonKickoffReturns : KickoffReturns
	{
		[JsonIgnore]
		public int PlayerId { get; set; }

		[JsonProperty("season")]
		public int Season { get; set; }

		[JsonProperty("team_abbreviation")]
		public string TeamAbbreviation { get; set; }

		[JsonProperty("games_played")]
		public int GamesPlayed { get; set; }

	}
}
