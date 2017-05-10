using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class FieldGoalsExtendedData
	{
		[JsonProperty("field_goals_attempts")]
		public string FieldGoalsAttempts { get; set; }

		[JsonProperty("field_goals_made")]
		public string FieldGoalsMade { get; set; }

		[JsonProperty("field_goals_pct")]
		public string FieldGoalsPercentage { get; set; }

		[JsonProperty("field_goals_long")]
		public string FieldGoalsLong { get; set; }

		[JsonProperty("field_goals_singles")]
		public string FieldGoalsSingles { get; set; }

		[JsonProperty("field_goals_blocked")]
		public string FieldGoalsBlocked { get; set; }

		[JsonProperty("field_goals_made_01_19")]
		public string FieldGoalsMade01to19 { get; set; }

		[JsonProperty("field_goals_made_20_29")]
		public string FieldGoalsMade20to29 { get; set; }

		[JsonProperty("field_goals_made_30_39")]
		public string FieldGoalsMade30to39 { get; set; }

		[JsonProperty("field_goals_made_40_49")]
		public string FieldGoalsMade40to49 { get; set; }

		[JsonProperty("field_goals_made_50_plus")]
		public string FieldGoalsMade50Plus { get; set; }

		[JsonProperty("extra_point_attempts")]
		public string ExtraPointAttempts { get; set; }

		[JsonProperty("extra_point_made")]
		public string ExtraPointMade { get; set; }

		[JsonProperty("extra_point_yards")]
		public string ExtraPointYards { get; set; }
	}
}
