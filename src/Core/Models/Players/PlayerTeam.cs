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

		[JsonProperty(PropertyName = "is_set")]
		public bool IsSet { get; set; }

		[JsonProperty(PropertyName = "team_id")]
		public int TeamId { get; set; }

		[JsonProperty(PropertyName = "location")]
		public string Location { get; set; }

		[JsonProperty(PropertyName = "nickname")]
		public string Nickname { get; set; }

		[JsonProperty(PropertyName = "abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty(PropertyName = "season")]
		public int Season { get; set; }
	}
}
