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
		[JsonProperty(PropertyName = "receieve_attempts")]
		public int ReceiveAttempts { get; set; }

		[JsonProperty(PropertyName = "receieve_caught")]
		public int ReceiveCaught { get; set; }

		[JsonProperty(PropertyName = "receieve_yards")]
		public int ReceiveYards { get; set; }

		[JsonProperty(PropertyName = "receieve_long")]
		public int ReceiveLong { get; set; }

		[JsonProperty(PropertyName = "receieve_touchdowns")]
		public int ReceiveTouchdowns { get; set; }

		[JsonProperty(PropertyName = "receieve_touchdowns_long")]
		public int ReceiveLongTouchdowns { get; set; }

		[JsonProperty(PropertyName = "receieve_second_down_conversions")]
		public int ReceiveSecondDownConversions { get; set; }

		[JsonProperty(PropertyName = "receieve_yards_after_catch")]
		public int ReceiveYardsAfterCatch { get; set; }

		[JsonProperty(PropertyName = "receieve_min_30")]
		public int ReceiveMin30 { get; set; }
	}
}
