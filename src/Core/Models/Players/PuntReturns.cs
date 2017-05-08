using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class PuntReturns
	{
		[JsonProperty("punt_returns")]
		public int PuntReturnsCount { get; set; }

		[JsonProperty("yards")]
		public int PuntReturnsYards { get; set; }

		[JsonProperty("average")]
		public decimal PuntReturnsAverage { get; set; }

		[JsonProperty("long")]
		public int PuntReturnsLong { get; set; }

		[JsonProperty("touchdowns")]
		public int PuntReturnsTouchdowns { get; set; }

		[JsonProperty("touchdowns_long")]
		public int PuntReturnsLongTouchdowns { get; set; }
	}
}
