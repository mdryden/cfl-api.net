using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.TeamLeaders
{
	public class TeamPassesDefended : TeamLeader
	{
		[JsonProperty("passes_defended")]
		public int PassesDefended { get; set; }
	}
}
