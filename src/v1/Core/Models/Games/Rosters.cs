using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	
	public class Rosters
	{
		[JsonProperty("teams")]
		public RosterTeams Teams { get; set; }
	}
}
