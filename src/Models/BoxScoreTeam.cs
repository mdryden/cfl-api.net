using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class BoxscoreTeam
	{

		[JsonProperty(PropertyName = "abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty(PropertyName = "team_id")]
		public int TeamId { get; set; }

		[JsonProperty(PropertyName = "passing")]
		public Passing Passing { get; set; }

		[JsonProperty(PropertyName = "rushing")]
		public Rushing Rushing { get; set; }

		[JsonProperty(PropertyName = "receiving")]
		public Receiving Receiving { get; set; }

		[JsonProperty(PropertyName = "punts")]
		public Punts Punts { get; set; }

		[JsonProperty(PropertyName = "punt_returns")]
		public PuntReturns PuntReturns { get; set; }

		[JsonProperty(PropertyName = "kick_returns")]
		public KickReturns KickReturns { get; set; }

		[JsonProperty(PropertyName = "field_goal_returns")]
		public FieldGoalReturns FieldGoalReturns { get; set; }

		[JsonProperty(PropertyName = "kicking")]
		public Kicking Kicking { get; set; }

		[JsonProperty(PropertyName = "defence")]
		public Defence Defence { get; set; }

		[JsonProperty(PropertyName = "players")]
		public BoxscorePlayers Players { get; set; }

	}
}
