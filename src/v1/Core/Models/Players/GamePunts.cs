using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class GamePunts : Punts
	{
		[JsonIgnore]
		public int PlayerId { get; set; }

		[JsonProperty("game_id")]
		public int GameId { get; set; }

		[JsonProperty("game_date")]
		public string GameDate { get; set; }

		[JsonProperty("week")]
		public int Week { get; set; }

		[JsonProperty("season")]
		public int Season { get; set; }

		[JsonProperty("opponent_team_abbreviation")]
		public string OpponentTeamAbbreviation { get; set; }

	}
}
