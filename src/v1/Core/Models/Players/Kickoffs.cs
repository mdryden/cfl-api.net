using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Kickoffs
	{
		[JsonProperty("kickoffs")]
		public int KickoffsTotal { get; set; }

		[JsonProperty("kickoffs_yards")]
		public int KickoffsYards { get; set; }

		[JsonProperty("kickoffs_net_yards")]
		public int KickoffsNetYards { get; set; }

		[JsonProperty("kickoffs_long")]
		public int KickoffsLong { get; set; }

		[JsonProperty("kickoffs_singles")]
		public int KickoffsSingles { get; set; }

		[JsonProperty("kickoffs_onside")]
		public int KickoffsOnside { get; set; }
		
	}
}
