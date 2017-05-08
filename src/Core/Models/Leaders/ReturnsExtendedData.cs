using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class ReturnsExtendedData
	{
		[JsonProperty("punt_returns_yards")]
		public string PuntReturnsYards { get; set; }

		[JsonProperty("punt_returns")]
		public string PuntReturns { get; set; }

		[JsonProperty("punt_returns_average")]
		public string PuntReturnsAverage { get; set; }

		[JsonProperty("punt_returns_long")]
		public string PuntReturnsLong { get; set; }

		[JsonProperty("punt_returns_touchdowns")]
		public string PuntReturnsTouchdowns { get; set; }

		[JsonProperty("kick_returns_yards")]
		public string KickReturnsYards { get; set; }

		[JsonProperty("kick_returns")]
		public string KickReturns { get; set; }

		[JsonProperty("kick_returns_average")]
		public string KickReturnsAverage { get; set; }

		[JsonProperty("kick_returns_long")]
		public string KickReturnsLong { get; set; }

		[JsonProperty("kick_returns_touchdowns")]
		public string KickReturnsTouchdowns { get; set; }
	}
}
