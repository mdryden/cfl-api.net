using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class PuntReturns
	{
		[JsonProperty("punt_returns")]
		public int PuntReturnsCount { get; set; }

		[JsonProperty("punt_returns_yards")]
		public int PuntReturnsYards { get; set; }

		[JsonProperty("punt_returns_touchdowns")]
		public int PuntReturnsTouchdowns { get; set; }

		[JsonProperty("punt_returns_long")]
		public int PuntReturnsLong { get; set; }

		[JsonProperty("punt_returns_touchdowns_long")]
		public int PuntReturnsTouchdownsLong { get; set; }
	}
}
