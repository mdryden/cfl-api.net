using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class RosterTeam
	{
		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("team_id")]
		public int TeamId { get; set; }

		[JsonProperty("roster")]
		public IList<RosterPlayer> Roster { get; set; }
	}
}
