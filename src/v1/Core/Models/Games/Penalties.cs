using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Penalties
	{
		[JsonProperty("total")]
		public int Total { get; set; }

		[JsonProperty("yards")]
		public int Yards { get; set; }

		[JsonProperty("offence_total")]
		public int OffenceTotal { get; set; }

		[JsonProperty("offence_yards")]
		public int OffenceYards { get; set; }

		[JsonProperty("defence_total")]
		public int DefenceTotal { get; set; }

		[JsonProperty("defence_yards")]
		public int DefenceYards { get; set; }

		[JsonProperty("special_teams_coverage_total")]
		public int SpecialTeamsCoverageTotal { get; set; }

		[JsonProperty("special_teams_coverage_yards")]
		public int SpecialTeamsCoverageYards { get; set; }

		[JsonProperty("special_teams_return_total")]
		public int SpecialTeamsReturnTotal { get; set; }

		[JsonProperty("special_teams_return_yards")]
		public int SpecialTeamsReturnYards { get; set; }
	}
}
