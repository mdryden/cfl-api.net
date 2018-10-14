using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Games
{
	public class PlayReview
	{
		[JsonProperty("play_id")]
		public int PlayId { get; set; }

		[JsonProperty("quarter")]
		public int Quarter { get; set; }

		[JsonProperty("play_clock_start")]
		public string PlayClockStart { get; set; }

		[JsonProperty("play_clock_start_in_secs")]
		public int PlayClockStartInSecs { get; set; }

		[JsonProperty("play_summary")]
		public string PlaySummary { get; set; }

		[JsonProperty("field_position_start")]
		public string FieldPositionStart { get; set; }

		[JsonProperty("field_position_end")]
		public string FieldPositionEnd { get; set; }

		[JsonProperty("down")]
		public int Down { get; set; }

		[JsonProperty("yards_to_go")]
		public int YardsToGo { get; set; }

		[JsonProperty("play_type_id")]
		public int PlayTypeId { get; set; }

		[JsonProperty("play_type_description")]
		public string PlayTypeDescription { get; set; }

		[JsonProperty("play_review_type_id")]
		public int PlayReviewTypeId { get; set; }

		[JsonProperty("play_review_type_name")]
		public string PlayReviewTypeName { get; set; }

		[JsonProperty("play_reversed_on_review")]
		public bool PlayReversedOnReview { get; set; }

		[JsonProperty("game_id")]
		public int GameId { get; set; }
	}
}