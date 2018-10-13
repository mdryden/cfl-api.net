using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Games
{
	public class GamePenalty
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
		public int PlayClockStartInSeconds { get; set; }

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

		[JsonProperty("penalty_id")]
		public int PenaltyId { get; set; }

		[JsonProperty("penalty_code")]
		public string PenaltyCode { get; set; }

		[JsonProperty("penalty_name")]
		public string Name { get; set; }

		[JsonProperty("PenaltyTypeId")]
		public int PenaltyTypeId { get; set; }

		[JsonProperty("penalty_type_name")]
		public string PenaltyTypeName { get; set; }

		[JsonProperty("penalty_situation_id")]
		public string PenaltySituationId { get; set; }

		[JsonProperty("penalty_situation_code")]
		public string PenaltySituationCode { get; set; }

		[JsonProperty("penalty_situation_name")]
		public string PenaltySituationName { get; set; }

		[JsonProperty("is_major")]
		public bool IsMajor { get; set; }

		[JsonProperty("was_accepted")]
		public bool WasAccepted { get; set; }

		[JsonProperty("team_or_player_penalty")]
		public string TeamOrPlayerPenalty { get; set; }

		[JsonProperty("team_abbreviation")]
		public string TeamAbbreviation { get; set; }

		[JsonProperty("team_id")]
		public int TeamId { get; set; }

		[JsonProperty("game_id")]
		public int GameId { get; set; }

		[JsonProperty("cfl_central_id")]
		public int CflCentralId { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("middle_name")]
		public string MiddleName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }
	}
}
