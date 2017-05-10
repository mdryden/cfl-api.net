using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class RosterTeams
	{
		[JsonProperty("team_1")]
		public RosterTeam Team1 { get; set; }

		[JsonProperty("team_2")]
		public RosterTeam Team2 { get; set; }
	}
}
