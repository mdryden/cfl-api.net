using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class RushingExtendedData
	{
		[JsonProperty("rushing_attempts")]
		public string RushingAttempts { get; set; }

		[JsonProperty("rushing_average")]
		public string RushingAverage { get; set; }

		[JsonProperty("rushing_long")]
		public string RushingLong { get; set; }

		[JsonProperty("rushing_touchdowns")]
		public string Rushing_Touchdowns { get; set; }

		[JsonProperty("rushing_touchdowns_long")]
		public string RushingTouchdownsLong { get; set; }

		[JsonProperty("rushing_min_10")]
		public string RushingMin10 { get; set; }

		[JsonProperty("rushing_min_20")]
		public string RushingMin20 { get; set; }
	}
}
