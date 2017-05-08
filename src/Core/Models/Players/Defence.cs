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
		[JsonProperty("tackles_total")]
		public int TacklesTotal { get; set; }

		[JsonProperty("tackles_yards")]
		public int Tackles_Yards { get; set; }

		[JsonProperty("tackles_defensive")]
		public int TacklesDefensive { get; set; }

		[JsonProperty("tackles_specialteams")]
		public int TacklesSpecialTeams { get; set; }

		[JsonProperty("tackles_for_loss")]
		public int TacklesForLoss { get; set; }

		[JsonProperty("sacks_qb_made")]
		public int SacksQbMade { get; set; }

		[JsonProperty("interceptions_made")]
		public int InterceptionsMade { get; set; }

		[JsonProperty("interceptions_yards")]
		public int InterceptionsYards { get; set; }

		[JsonProperty("interceptions_long")]
		public int InterceptionsLong { get; set; }

		[JsonProperty("interceptions_touchdowns")]
		public int InterceptionsTouchdowns { get; set; }

		[JsonProperty("interceptions_touchdowns_long")]
		public int InterceptionsTouchdownsLong { get; set; }

		[JsonProperty("fumbles_forced")]
		public int FumblesForced {  get; set; }

		[JsonProperty("fumble_returns")]
		public int FumbleReturns { get; set; }

		[JsonProperty("fumble_returns_yards")]
		public int FumbleReturnYards { get; set; }

		[JsonProperty("fumble_returns_long")]
		public int FumbleReturnsLong { get; set; }

		[JsonProperty("fumble_returns_touchdowns")]
		public int FumbleReturnsTouchdowns { get; set; }

		[JsonProperty("fumble_returns_touchdowns_long")]
		public int FumbleReturnsTouchdownsLong { get; set; }

		[JsonProperty("passes_knocked_down")]
		public int PassesKnockedDown { get; set; }

	}
}
