using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class FieldGoalReturns
	{
		[JsonProperty("field_goal_returns")]
		public int FieldGoalReturnsCount { get; set; }

		[JsonProperty("field_goal_returns_yards")]
		public int FieldGoalReturnsYards { get; set; }

		[JsonProperty("field_goal_returns_touchdowns")]
		public int FieldGoalReturnsTouchdowns { get; set; }

		[JsonProperty("field_goal_returns_long")]
		public int FieldGoalReturnsLong { get; set; }

		[JsonProperty("field_goal_returns_touchdowns_long")]
		public int FieldGoalReturnsTouchdownsLong { get; set; }
	}
}
