using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class FieldGoals
	{
		[JsonProperty("field_goal_attempts")]
		public int FieldGoalAttempts { get; set; }

		[JsonProperty("field_goal_made")]
		public int FieldGoalMade{ get; set; }

		[JsonProperty("field_goal_yards")]
		public int FieldGoalYards{ get; set; }

		[JsonProperty("field_goal_singles")]
		public int FieldGoalSingles{ get; set; }

		[JsonProperty("field_goal_long")]
		public int FieldGoalLong{ get; set; }

		[JsonProperty("field_goal_points")]
		public int FieldGoalPoints{ get; set; }
	}
}
