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

		[JsonProperty(PropertyName = "abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty(PropertyName = "team_id")]
		public int TeamId { get; set; }

		[JsonProperty(PropertyName = "passing")]
		public TeamPassing Passing { get; set; }

		[JsonProperty(PropertyName = "rushing")]
		public TeamRushing Rushing { get; set; }

		[JsonProperty(PropertyName = "receiving")]
		public TeamReceiving Receiving { get; set; }

		[JsonProperty(PropertyName = "punts")]
		public TeamPunts Punts { get; set; }

		[JsonProperty(PropertyName = "punt_returns")]
		public TeamPuntReturns PuntReturns { get; set; }

		[JsonProperty(PropertyName = "kick_returns")]
		public TeamKickReturns KickReturns { get; set; }

		[JsonProperty(PropertyName = "field_goal_returns")]
		public TeamFieldGoalReturns FieldGoalReturns { get; set; }

		[JsonProperty(PropertyName = "kicking")]
		public TeamKicking Kicking { get; set; }

		[JsonProperty(PropertyName = "defence")]
		public TeamDefence Defence { get; set; }

		[JsonProperty(PropertyName = "players")]
		public BoxscorePlayers Players { get; set; }

	}
}
