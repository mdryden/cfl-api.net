using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.TeamLeaders
{
	public class TeamRushingYards : TeamLeader
	{
		[JsonProperty("rushing_yards")]
		public int RushingYards { get; set; }
	}
}
