using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Defence
	{
		[JsonProperty(PropertyName = "tackles_total")]
		public int TacklesTotal { get; set; }

		[JsonProperty(PropertyName = "tackles_yards")]
		public int Tackles_Yards { get; set; }

		[JsonProperty(PropertyName = "tackles_defensive")]
		public int TacklesDefensive { get; set; }

		[JsonProperty(PropertyName = "tackles_specialteams")]
		public int TacklesSpecialTeams { get; set; }

		[JsonProperty(PropertyName = "tackles_for_loss")]
		public int TacklesForLoss { get; set; }

		[JsonProperty(PropertyName = "sacks_qb_made")]
		public int SacksQbMade { get; set; }

		[JsonProperty(PropertyName = "interceptions_made")]
		public int InterceptionsMade { get; set; }

		[JsonProperty(PropertyName = "interceptions_yards")]
		public int InterceptionsYards { get; set; }

		[JsonProperty(PropertyName = "interceptions_long")]
		public int InterceptionsLong { get; set; }

		[JsonProperty(PropertyName = "interceptions_touchdowns")]
		public int InterceptionsTouchdowns { get; set; }

		[JsonProperty(PropertyName = "interceptions_touchdowns_long")]
		public int InterceptionsTouchdownsLong { get; set; }

		[JsonProperty(PropertyName = "fumbles_forced")]
		public int FumblesForced {  get; set; }

		[JsonProperty(PropertyName = "fumble_returns")]
		public int FumbleReturns { get; set; }

		[JsonProperty(PropertyName = "fumble_returns_yards")]
		public int FumbleReturnYards { get; set; }

		[JsonProperty(PropertyName = "fumble_returns_long")]
		public int FumbleReturnsLong { get; set; }

		[JsonProperty(PropertyName = "fumble_returns_touchdowns")]
		public int FumbleReturnsTouchdowns { get; set; }

		[JsonProperty(PropertyName = "fumble_returns_touchdowns_long")]
		public int FumbleReturnsTouchdownsLong { get; set; }

		[JsonProperty(PropertyName = "passes_knocked_down")]
		public int PassesKnockedDown { get; set; }

	}
}
