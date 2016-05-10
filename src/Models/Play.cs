using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Play
	{
		[JsonProperty(PropertyName = "play_id")]
		public int PlayId { get; set; }

		[JsonProperty(PropertyName = "play_sequence")]
		public int PlaySequence { get; set; }

		[JsonProperty(PropertyName = "quarter")]
		public int Quarter { get; set; }

		[JsonProperty(PropertyName = "play_clock_start")]
		public string PlayClockStart { get; set; }

		[JsonProperty(PropertyName = "play_clock_start_in_secs")]
		public int PlayClockStartInSecs { get; set; }

		[JsonProperty(PropertyName = "field_position_start")]
		public string FieldPositionStart { get; set; }

		[JsonProperty(PropertyName = "field_position_end")]
		public string FieldPositionEnd { get; set; }

		[JsonProperty(PropertyName = "down")]
		public int Down { get; set; }

		[JsonProperty(PropertyName = "yards_to_go")]
		public int YardsToGo { get; set; }

		[JsonProperty(PropertyName = "team_home_score")]
		public int TeamHomeScore { get; set; }

		[JsonProperty(PropertyName = "team_visitor_score")]
		public int TeamVisitorScore { get; set; }

		[JsonProperty(PropertyName = "play_type_id")]
		public int PlayTypeId { get; set; }

		[JsonProperty(PropertyName = "play_type_description")]
		public string PlayTypeDescription { get; set; }

		[JsonProperty(PropertyName = "play_result_type_id")]
		public int PlayResultTypeId { get; set; }

		[JsonProperty(PropertyName = "play_result_type_description")]
		public string PlayResultTypeDescription { get; set; }

		[JsonProperty(PropertyName = "play_result_yards")]
		public int PlayResultYards { get; set; }

		[JsonProperty(PropertyName = "play_result_points")]
		public int PlayResultPoints { get; set; }

		[JsonProperty(PropertyName = "play_change_of_possession_occurred")]
		public bool PlayChangeOfPossessionOccurred { get; set; }

		[JsonProperty(PropertyName = "team_abbreviation")]
		public string TeamAbbreviation { get; set; }

		[JsonProperty(PropertyName = "team_id")]
		public int TeamId { get; set; }

		[JsonProperty(PropertyName = "players")]
		public PlayPlayers Players { get; set; }

		[JsonProperty(PropertyName = "play_summary")]
		public string PlaySummary { get; set; }
	}
}
