using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class KickReturns
	{
		[JsonProperty("kick_returns")]
		public int KickReturnsCount { get; set; }

		[JsonProperty("kick_returns_yards")]
		public int KickReturnsYards { get; set; }

		[JsonProperty("kick_returns_touchdowns")]
		public int KickReturnsTouchdowns { get; set; }

		[JsonProperty("kick_returns_long")]
		public int KickReturnsLong { get; set; }

		[JsonProperty("kick_returns_touchdowns_long")]
		public int KickReturnsTouchdownsLong { get; set; }
	}
}
