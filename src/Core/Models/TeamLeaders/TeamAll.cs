using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.TeamLeaders
{
	public class TeamAll
	{
		[JsonProperty("total_yards")]
		public IList<TeamTotalYards> TotalYards { get; set; }

		[JsonProperty("passing_yards")]
		public IList<TeamPassingYards> PassingYards { get; set; }

		[JsonProperty("passing_touchdowns")]
		public IList<TeamPassingTouchdowns> PassingTouchdowns { get; set; }

		[JsonProperty("rushing_yards")]
		public IList<TeamRushingYards> RushingYards { get; set; }

		[JsonProperty("rushing_touchdowns")]
		public IList<TeamRushingTouchdowns> RushingTouchdowns { get; set; }

		[JsonProperty("sacks")]
		public IList<TeamSacks> Sacks { get; set; }

		[JsonProperty("interceptions")]
		public IList<TeamInterceptions> Interceptions { get; set; }

		[JsonProperty("fumbles_forced")]
		public IList<TeamFumblesForced> FumblesForced { get; set; }

		[JsonProperty("passes_defended")]
		public IList<TeamPassesDefended> PassesDefended { get; set; }
}
}
