using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Rushing
	{
		[JsonProperty("rush_attempts")]
		public int RushAttempts { get; set; }

		[JsonProperty("rush_yards")]
		public int RushYards { get; set; }

		[JsonProperty("rush_average")]
		public decimal RushAverage { get; set; }

		[JsonProperty("rush_long")]
		public int RushLong { get; set; }

		[JsonProperty("rush_touchdowns")]
		public int RushTouchdowns { get; set; }

		[JsonProperty("rush_touchdowns_long")]
		public int RushLongTouchdowns { get; set; }

		[JsonProperty("rush_min_10")]
		public int RushMin10 { get; set; }

		[JsonProperty("rush_min_20")]
		public int RushMin20 { get; set; }
	}
}
