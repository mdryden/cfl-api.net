using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Kicking
	{
		[JsonProperty(PropertyName = "kicks")]
		public int Kicks { get; set; }

		[JsonProperty(PropertyName = "kick_yards")]
		public int KickYards { get; set; }

		[JsonProperty(PropertyName = "kicks_net_yards")]
		public int KicksNetYards { get; set; }

		[JsonProperty(PropertyName = "kicks_long")]
		public int KicksLong { get; set; }

		[JsonProperty(PropertyName = "kicks_singles")]
		public int KicksSingles { get; set; }

		[JsonProperty(PropertyName = "kicks_out_of_end_zone")]
		public int KicksOutOfEndZone { get; set; }

		[JsonProperty(PropertyName = "kicks_onside")]
		public int KicksOnside { get; set; }
	}
}
