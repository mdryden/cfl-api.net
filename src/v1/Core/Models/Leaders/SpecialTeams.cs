using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class SpecialTeams
	{
		[JsonProperty("field_goals")]
		public IList<PlayerFieldGoals> FieldGoals { get; set; }

		[JsonProperty("kicking")]
		public IList<PlayerKicking> Kicking { get; set; }

		[JsonProperty("returns")]
		public IList<PlayerReturns> Returns { get; set; }

		[JsonProperty("return_yards")]
		public IList<PlayerReturnYards> ReturnYards { get; set; }
		
		[JsonProperty("field_goal_missed_return_yards")]
		public IList<PlayerFieldGoalMissedReturnYards> FieldGoalMissedReturnYards { get; set; }

		[JsonProperty("kickoff_yards")]
		public IList<PlayerKickoffYards> KickoffYards { get; set; }

		[JsonProperty("tackles_special_teams")]
		public IList<PlayerTacklesSpecialTeams> TacklesSpecialTeams { get; set; }

		[JsonProperty("kicks_blocked")]
		public IList<PlayerKicksBlocked> KicksBlocked { get; set; }

		[JsonProperty("kickoff_return_yards")]
		public IList<PlayerKickoffReturnYards> KickoffReturnYards { get; set; }

		[JsonProperty("converts")]
		public IList<PlayerConverts1> Converts1 { get; set; }

		[JsonProperty("converts_2pt")]
		public IList<PlayerConverts2> Converts2 { get; set; }
	}
}
