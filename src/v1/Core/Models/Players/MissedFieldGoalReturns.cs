using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class MissedFieldGoalReturns
	{
		[JsonProperty("missed_fg_returns")]
		public int MissedFieldGoalReturnsCount { get; set; }

		[JsonProperty("yards")]
		public int MissedFieldGoalReturnsYards { get; set; }

		[JsonProperty("average")]
		public decimal MissedFieldGoalReturnsAverage { get; set; }

		[JsonProperty("long")]
		public int MissedFieldGoalReturnsLong { get; set; }

		[JsonProperty("touchdowns")]
		public int MissedFieldGoalReturnsTouchdowns { get; set; }

		[JsonProperty("touchdowns_long")]
		public int MissedFieldGoalReturnsLongTouchdowns { get; set; }
	}
}
