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
		[JsonProperty("receive_attempts")]
		public int ReceiveAttempts { get; set; }

		[JsonProperty("receive_caught")]
		public int ReceiveCaught { get; set; }

		[JsonProperty("receive_average")]
		public decimal ReceiveAverage { get; set; }

		[JsonProperty("receive_yards")]
		public int ReceiveYards { get; set; }

		[JsonProperty("receive_long")]
		public int ReceiveLong { get; set; }

		[JsonProperty("receive_touchdowns")]
		public int ReceiveTouchdowns { get; set; }

		[JsonProperty("receive_touchdowns_long")]
		public int ReceiveLongTouchdowns { get; set; }

		[JsonProperty("receive_second_down_conversions")]
		public int ReceiveSecondDownConversions { get; set; }

		[JsonProperty("receive_yards_after_catch")]
		public int ReceiveYardsAfterCatch { get; set; }

		[JsonProperty("receive_min_30")]
		public int ReceiveMin30 { get; set; }
	}
}
