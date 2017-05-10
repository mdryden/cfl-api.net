using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Punts
	{
		[JsonProperty("punts")]
		public int PuntsCount { get; set; }

		[JsonProperty("punt_yards")]
		public int PuntYards { get; set; }

		[JsonProperty("punt_net_yards")]
		public int PuntNetYards { get; set; }

		[JsonProperty("punt_long")]
		public int PuntLong { get; set; }

		[JsonProperty("punt_singles")]
		public int PuntSingles { get; set; }

		[JsonProperty("punts_blocked")]
		public int PuntsBlocked { get; set; }

		[JsonProperty("punts_in_10")]
		public int PuntsIn10 { get; set; }

		[JsonProperty("punts_in_20")]
		public int PuntsIn20 { get; set; }

		[JsonProperty("punts_returned")]
		public int PuntsReturned { get; set; }

	}
}
