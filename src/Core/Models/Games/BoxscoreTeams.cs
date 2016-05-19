using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class BoxscoreTeams
	{
		[JsonIgnore]
		public int GameId { get; set; }

		[JsonProperty(PropertyName = "team_1")]
		public BoxscoreTeam Team1 { get; set; }

		[JsonProperty(PropertyName = "team_2")]
		public BoxscoreTeam Team2 { get; set; }


	}
}
