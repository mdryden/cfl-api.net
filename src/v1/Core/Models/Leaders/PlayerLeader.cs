using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerLeader
	{
		[JsonProperty("season")]
		public int Season { get; set; }

		[JsonProperty("games_played")]
		public int GamesPlayed { get; set; }

		[JsonProperty("cfl_central_id")]
		public int CflCentralId { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("middle_name")]
		public string MiddleName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("birth_date")]
		public DateTime BirthDate { get; set; }

		[JsonProperty("uniform")]
		public int UniformNumber { get; set; }

		[JsonProperty("team_abbreviation")]
		public string TeamAbbreviation { get; set; }

		[JsonProperty("team_location")]
		public string TeamLocation { get; set; }

		[JsonProperty("team_nickname")]
		public string TeamNickname { get; set; }
	}
}
