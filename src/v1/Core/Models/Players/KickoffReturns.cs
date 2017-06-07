using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class KickoffReturns
	{
		[JsonProperty("kickoff_returns")]
		public int KickoffReturnsCount { get; set; }

		[JsonProperty("yards")]
		public int KickoffReturnsYards { get; set; }

		[JsonProperty("average")]
		public decimal KickoffReturnsAverage { get; set; }

		[JsonProperty("long")]
		public int KickoffReturnsLong { get; set; }

		[JsonProperty("touchdowns")]
		public int KickoffReturnsTouchdowns { get; set; }

		[JsonProperty("touchdowns_long")]
		public int KickoffReturnsLongTouchdowns { get; set; }
	}
}
