using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.TeamLeaders
{
	public class TeamTotalYards : TeamLeader
	{
		[JsonProperty("total_yards")]
		public int TotalYards { get; set; }
	}
}
