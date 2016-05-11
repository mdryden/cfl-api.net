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
		[JsonProperty(PropertyName = "punts")]
		public int PuntsCount { get; set; }

		[JsonProperty(PropertyName = "punts_yards")]
		public int PuntYards { get; set; }

		[JsonProperty(PropertyName = "punts_net_yards")]
		public int PuntsNetYards { get; set; }

		[JsonProperty(PropertyName = "punts_long")]
		public int PuntsLong { get; set; }

		[JsonProperty(PropertyName = "punts_singles")]
		public int PuntsSingles { get; set; }

		[JsonProperty(PropertyName = "punts_blocked")]
		public int PuntsBlocked { get; set; }

		[JsonProperty(PropertyName = "punts_in_10")]
		public int PuntsIn10 { get; set; }

		[JsonProperty(PropertyName = "punts_in_20")]
		public int PuntsIn20 { get; set; }

		[JsonProperty(PropertyName = "punts_returned")]
		public int PuntsReturned { get; set; }

	}
}
