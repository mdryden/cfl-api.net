using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class PlayerTeam
	{
		//[JsonIgnore]
		//public int PlayerTeamId
		//{
		//	get { return TeamId; }
		//	set { TeamId = value; }
		//}

		[JsonProperty("is_set")]
		public bool IsSet { get; set; }

		[JsonProperty("team_id")]
		public int TeamId { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("nickname")]
		public string Nickname { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("season")]
		public int Season { get; set; }

		[JsonProperty("uniform")]
		public int? Uniform { get; set; }
	}
}
