using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.TeamLeaders
{
	public class TeamFumblesForced : TeamLeader
	{
		[JsonProperty("fumbles_forced")]
		public int FumblesForced { get; set; }
	}
}
