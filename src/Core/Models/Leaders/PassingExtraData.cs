using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PassingExtendedData
	{
		[JsonProperty("passing_attempts")]
		public string PassingAttempts { get; set; }

		[JsonProperty("passing_completions")]
		public string PassingCompletions { get; set; }

		[JsonProperty("passing_percentage")]
		public string PassingPercentage { get; set; }

		[JsonProperty("passing_long")]
		public string PassingLong { get; set; }

		[JsonProperty("passing_touchdowns")]
		public string PassingTouchdowns { get; set; }

		[JsonProperty("passing_touchdowns_long")]
		public string PassingTouchdownsLong { get; set; }

		[JsonProperty("passing_interceptions")]
		public string PassingInterceptions { get; set; }

		[JsonProperty("passing_efficiency")]
		public string PassingEfficiency { get; set; }

		[JsonProperty("passing_int_pct")]
		public string PassingInterceptionPercentage { get; set; }

		[JsonProperty("passing_average")]
		public string PassingAverage { get; set; }
	}
}
