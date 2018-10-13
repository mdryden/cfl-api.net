using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Receiving
	{
		[JsonProperty("receive_attempts")]
		public int ReceiveAttempts { get; set; }

		[JsonProperty("receive_caught")]
		public int ReceiveCaught { get; set; }

		[JsonProperty("receive_yards")]
		public int ReceiveYards { get; set; }

		[JsonProperty("receive_long")]
		public int ReceiveLong { get; set; }

		[JsonProperty("receive_touchdowns")]
		public int ReceiveTouchdowns { get; set; }

		[JsonProperty("receive_long_touchdowns")]
		public int ReceiveLongTouchdowns { get; set; }

		[JsonProperty("receive_yards_after_catch")]
		public int ReceiveYardsAfterCatch { get; set; }

		[JsonProperty("receive_fumbles")]
		public int ReceiveFumbles { get; set; }
	}
}
