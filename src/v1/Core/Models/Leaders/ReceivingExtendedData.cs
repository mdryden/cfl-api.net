using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class ReceivingExtendedData
	{
		[JsonProperty("receiving_attempts")]
		public string ReceivingAttempts { get; set; }

		[JsonProperty("receiving_caught")]
		public string ReceivingCaught { get; set; }

		[JsonProperty("receiving_average")]
		public string ReceivingAverage { get; set; }

		[JsonProperty("receiving_long")]
		public string ReceivingLong { get; set; }

		[JsonProperty("receiving_touchdowns")]
		public string ReceivingTouchdowns { get; set; }

		[JsonProperty("receiving_touchdowns_long")]
		public string ReceivingTouchdownsLong { get; set; }

		[JsonProperty("receiving_yards_after_catch")]
		public string ReceivingYardsAfterCatch { get; set; }

		[JsonProperty("receiving_min_30")]
		public string ReceivingMin30 { get; set; }
	}
}
