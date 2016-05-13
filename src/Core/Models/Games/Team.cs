using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Team
	{
		[JsonProperty(PropertyName = "team_id")]
		public int TeamId { get; set; }

		[JsonProperty(PropertyName = "location")]
		public string Location { get; set; }

		[JsonProperty(PropertyName = "nickname")]
		public string Nickname { get; set; }

		[JsonProperty(PropertyName = "abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty(PropertyName = "score")]
		public int score { get; set; }

		[JsonProperty(PropertyName = "venue_id")]
		public int VenueId { get; set; }

		[JsonProperty(PropertyName = "linescores")]
		public IList<LineScore> LineScores { get; set; }

		[JsonProperty(PropertyName = "is_at_home")]
		public bool IsAtHome { get; set; }

		[JsonProperty(PropertyName = "is_winner")]
		public bool IsWinner { get; set; }
	}
}
