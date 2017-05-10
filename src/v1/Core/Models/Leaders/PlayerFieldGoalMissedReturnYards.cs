using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerFieldGoalMissedReturnYards : PlayerLeader
	{
		[JsonProperty("field_goal_missed_return_yards")]
		public int FieldMissedGoalReturnYards { get; set; }
	}
}
