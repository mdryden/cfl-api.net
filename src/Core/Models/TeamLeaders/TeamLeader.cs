using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.TeamLeaders
{
	public class TeamLeader
	{
		[JsonProperty("season")]
		public int Season { get; set; }

		[JsonProperty("games_played")]
		public int GamesPlayed { get; set; }

		[JsonProperty("team_abbreviation")]
		public string TeamAbbreviation { get; set; }

		[JsonProperty("team_location")]
		public string TeamLocation { get; set; }

		[JsonProperty("team_nickname")]
		public string TeamNickname { get; set; }
	}
}
