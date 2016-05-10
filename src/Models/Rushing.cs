using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Rushing
	{
		[JsonProperty(PropertyName = "rush_attempts")]
		public int RushAttempts { get; set; }

		[JsonProperty(PropertyName = "rush_net_yards")]
		public int RushNetYards { get; set; }

		[JsonProperty(PropertyName = "rush_long")]
		public int RushLong { get; set; }

		[JsonProperty(PropertyName = "rush_touchdowns")]
		public int RushTouchdowns { get; set; }

		[JsonProperty(PropertyName = "rush_long_touchdowns")]
		public int RushLongTouchdowns { get; set; }
	}
}
