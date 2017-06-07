using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class FieldGoals
	{
		[JsonProperty("field_goals_attempts")]
		public int FieldGoalsAttempts { get; set; }

		[JsonProperty("field_goals_made")]
		public int FieldGoalsMade { get; set; }

		[JsonProperty("field_goals_long")]
		public int FieldGoalsLong { get; set; }

		[JsonProperty("field_goals_singles")]
		public int FieldGoalsSingles { get; set; }

		[JsonProperty("field_goals_blocked")]
		public int FieldGoalsBlocked { get; set; }

		[JsonProperty("field_goals_made_01_19")]
		public int FieldGoalsMade01to19 { get; set; }

		[JsonProperty("field_goals_made_20_29")]
		public int FieldGoalsMade20to29 { get; set; }

		[JsonProperty("field_goals_made_30_39")]
		public int FieldGoalsMade30to39 { get; set; }

		[JsonProperty("field_goals_made_40_49")]
		public int FieldGoalsMade40to49 { get; set; }

		[JsonProperty("field_goals_made_50_plus")]
		public int FieldGoalsMade50Plus { get; set; }

		[JsonProperty("extra_point_attempts")]
		public int ExtraPointAttempts { get; set; }

		[JsonProperty("extra_point_made")]
		public int ExtraPointMade { get; set; }

		[JsonProperty("extra_point_yards")]
		public int ExtraPointYards { get; set; }

		[JsonProperty("points")]
		public int Points { get; set; }
	}
}
