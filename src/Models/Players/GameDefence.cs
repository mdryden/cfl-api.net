using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class GameDefence : Defence
	{
		[JsonProperty(PropertyName = "game_id")]
		public int GameId { get; set; }

		[JsonProperty(PropertyName = "game_date")]
		public string GameDate { get; set; }

		[JsonProperty(PropertyName = "week")]
		public int Week { get; set; }

		[JsonProperty(PropertyName = "season")]
		public int Season { get; set; }

		[JsonProperty(PropertyName = "opponent_team_abbreviation")]
		public string OpponentTeamAbbreviation { get; set; }

	}
}
