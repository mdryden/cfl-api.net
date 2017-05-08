using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Play
	{
		[JsonProperty("play_id")]
		public int PlayId { get; set; }

		[JsonProperty("play_sequence")]
		public int PlaySequence { get; set; }

		[JsonProperty("quarter")]
		public int Quarter { get; set; }

		[JsonProperty("play_clock_start")]
		public string PlayClockStart { get; set; }

		[JsonProperty("play_clock_start_in_secs")]
		public int PlayClockStartInSecs { get; set; }

		[JsonProperty("field_position_start")]
		public string FieldPositionStart { get; set; }

		[JsonProperty("field_position_end")]
		public string FieldPositionEnd { get; set; }

		[JsonProperty("down")]
		public int Down { get; set; }

		[JsonProperty("yards_to_go")]
		public int YardsToGo { get; set; }

		/// <summary>
		/// Added in v1.05
		/// </summary>
		[JsonProperty("is_in_red_zone")]
		public bool IsInRedZone { get; set; }

		[JsonProperty("team_home_score")]
		public int TeamHomeScore { get; set; }

		[JsonProperty("team_visitor_score")]
		public int TeamVisitorScore { get; set; }

		/// <summary>
		/// Added in v1.07
		/// </summary>
		[JsonProperty("play_type_id")]
		public int PlayTypeId { get; set; }

		/// <summary>
		/// Added in v1.07
		/// </summary>
		[JsonProperty("play_type_description")]
		public string PlayTypeDescription { get; set; }

		[JsonProperty("play_result_type_id")]
		public int PlayResultTypeId { get; set; }

		[JsonProperty("play_result_type_description")]
		public string PlayResultTypeDescription { get; set; }

		[JsonProperty("play_result_yards")]
		public int PlayResultYards { get; set; }

		[JsonProperty("play_result_points")]
		public int PlayResultPoints { get; set; }

		[JsonProperty("play_success_id")]
		public int PlaySuccessId { get; set; }

		[JsonProperty("play_success_description")]
		public string PlaySuccessDescription { get; set; }

		[JsonProperty("play_change_of_possession_occurred")]
		public bool PlayChangeOfPossessionOccurred { get; set; }

		[JsonProperty("team_abbreviation")]
		public string TeamAbbreviation { get; set; }

		[JsonProperty("team_id")]
		public int TeamId { get; set; }

		[JsonProperty("players")]
		public PlayPlayers Players { get; set; }

		[JsonProperty("play_summary")]
		public string PlaySummary { get; set; }
	}
}
