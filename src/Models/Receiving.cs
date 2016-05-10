using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Receiving
	{
		[JsonProperty(PropertyName = "receive_attempts")]
		public int ReceiveAttempts { get; set; }

		[JsonProperty(PropertyName = "receive_caught")]
		public int ReceiveCaught { get; set; }

		[JsonProperty(PropertyName = "receive_yards")]
		public int ReceiveYards { get; set; }

		[JsonProperty(PropertyName = "receive_long")]
		public int ReceiveLong { get; set; }

		[JsonProperty(PropertyName = "receive_touchdowns")]
		public int ReceiveTouchdowns { get; set; }

		[JsonProperty(PropertyName = "receive_long_touchdowns")]
		public int ReceiveLongTouchdowns { get; set; }
	}
}
