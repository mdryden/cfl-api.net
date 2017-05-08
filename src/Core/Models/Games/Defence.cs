using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Defence
	{
		[JsonProperty("tackles_total")]
		public int TacklesTotal { get; set; }

		[JsonProperty("tackles_defensive")]
		public int TacklesDefensive { get; set; }

		[JsonProperty("tackles_special_teams")]
		public int TacklesSpecialTeams { get; set; }

		[JsonProperty("sacks_qb_made")]
		public int SacksQbMade { get; set; }

		[JsonProperty("interceptions")]
		public int Interceptions { get; set; }

		[JsonProperty("fumbles_forced")]
		public int FumblesForced {  get; set; }

		[JsonProperty("fumbles_recovered")]
		public int FumblesRecovered { get; set; }

		[JsonProperty("passes_knocked_down")]
		public int PassesKnockedDown { get; set; }

	}
}
