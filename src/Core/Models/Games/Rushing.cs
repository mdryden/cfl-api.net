using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Rushing
	{
		[JsonProperty("rush_attempts")]
		public int RushAttempts { get; set; }

		[JsonProperty("rush_net_yards")]
		public int RushNetYards { get; set; }

		[JsonProperty("rush_long")]
		public int RushLong { get; set; }

		[JsonProperty("rush_touchdowns")]
		public int RushTouchdowns { get; set; }

		[JsonProperty("rush_long_touchdowns")]
		public int RushLongTouchdowns { get; set; }
	}
}
