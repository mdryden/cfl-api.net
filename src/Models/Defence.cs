using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Defence
	{
		[JsonProperty(PropertyName = "tackles_total")]
		public int TacklesTotal { get; set; }

		[JsonProperty(PropertyName = "tackles_defensive")]
		public int TacklesDefensive { get; set; }

		[JsonProperty(PropertyName = "tackles_special_teams")]
		public int TacklesSpecialTeams { get; set; }

		[JsonProperty(PropertyName = "sacks_qb_made")]
		public int SacksQbMade { get; set; }

		[JsonProperty(PropertyName = "interceptions")]
		public int Interceptions { get; set; }

		[JsonProperty(PropertyName = "fumbles_forced")]
		public int FumblesForced {  get; set; }

		[JsonProperty(PropertyName = "fumbles_recovered")]
		public int FumblesRecovered { get; set; }

		[JsonProperty(PropertyName = "passes_knocked_down")]
		public int PassesKnockedDown { get; set; }

	}
}
