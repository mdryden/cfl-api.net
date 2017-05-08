using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Punts
	{
		[JsonProperty("punts")]
		public int PuntsCount { get; set; }

		[JsonProperty("punts_yards")]
		public int PuntYards { get; set; }

		[JsonProperty("punts_net_yards")]
		public int PuntsNetYards { get; set; }

		[JsonProperty("punts_long")]
		public int PuntsLong { get; set; }

		[JsonProperty("punts_singles")]
		public int PuntsSingles { get; set; }

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
