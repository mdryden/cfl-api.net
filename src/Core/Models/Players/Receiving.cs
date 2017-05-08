using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Receiving
	{
		[JsonProperty("receieve_attempts")]
		public int ReceiveAttempts { get; set; }

		[JsonProperty("receieve_caught")]
		public int ReceiveCaught { get; set; }

		[JsonProperty("receieve_yards")]
		public int ReceiveYards { get; set; }

		[JsonProperty("receieve_long")]
		public int ReceiveLong { get; set; }

		[JsonProperty("receieve_touchdowns")]
		public int ReceiveTouchdowns { get; set; }

		[JsonProperty("receieve_touchdowns_long")]
		public int ReceiveLongTouchdowns { get; set; }

		[JsonProperty("receieve_second_down_conversions")]
		public int ReceiveSecondDownConversions { get; set; }

		[JsonProperty("receieve_yards_after_catch")]
		public int ReceiveYardsAfterCatch { get; set; }

		[JsonProperty("receieve_min_30")]
		public int ReceiveMin30 { get; set; }
	}
}
