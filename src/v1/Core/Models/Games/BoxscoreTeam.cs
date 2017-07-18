using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class BoxscoreTeam
	{
		[JsonIgnore]
		public int GameId { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("team_id")]
		public int TeamId { get; set; }

		[JsonProperty("offence")]
		public Offence Offence { get; set; }

		[JsonProperty("turnovers")]
		public Turnovers Turnovers { get; set; }

		[JsonProperty("passing")]
		public TeamPassing Passing { get; set; }

		[JsonProperty("rushing")]
		public TeamRushing Rushing { get; set; }

		[JsonProperty("receiving")]
		public TeamReceiving Receiving { get; set; }

		[JsonProperty("punts")]
		public TeamPunts Punts { get; set; }

		[JsonProperty("punt_returns")]
		public TeamPuntReturns PuntReturns { get; set; }

		[JsonProperty("kick_returns")]
		public TeamKickReturns KickReturns { get; set; }

		[JsonProperty("field_goals")]
		public TeamFieldGoals FieldGoals { get; set; }

		[JsonProperty("field_goal_returns")]
		public TeamFieldGoalReturns FieldGoalReturns { get; set; }

		[JsonProperty("kicking")]
		public TeamKicking Kicking { get; set; }

		[JsonProperty("converts")]
		public TeamConverts Converts { get; set; }

		[JsonProperty("defence")]
		public TeamDefence Defence { get; set; }

		[JsonProperty("penalties")]
		public Penalties Penalties { get; set; }

		[JsonProperty("players")]
		public BoxscorePlayers Players { get; set; }

	}
}
