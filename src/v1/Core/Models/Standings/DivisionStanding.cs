using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Standings
{
	public class DivisionStanding
	{
		[JsonProperty("season")]
		public int Season { get; set; }

		[JsonProperty("division_id")]
		public int DivisionId { get; set; }

		[JsonProperty("division_name")]
		public string DivisionName { get; set; }

		[JsonProperty("place")]
		public int Place { get; set; }

		[JsonProperty("flags")]
		public string Flags { get; set; }

		[JsonProperty("team_id")]
		public int TeamId { get; set; }

		[JsonProperty("letter")]
		public string Letter { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("nickname")]
		public string Nickname { get; set; }

		[JsonProperty("full_name")]
		public string FullName { get; set; }

		[JsonProperty("games_played")]
		public int GamesPlayed { get; set; }

		[JsonProperty("wins")]
		public int Wins { get; set; }

		[JsonProperty("losses")]
		public int Losses { get; set; }

		[JsonProperty("ties")]
		public int Ties { get; set; }

		[JsonProperty("points")]
		public int Points { get; set; }

		[JsonProperty("winning_percentage")]
		public decimal WinningPercentage { get; set; }

		[JsonProperty("points_for")]
		public int PointsFor { get; set; }

		[JsonProperty("points_against")]
		public int PointsAgainst { get; set; }

		[JsonProperty("home_wins")]
		public int HomeWins { get; set; }

		[JsonProperty("home_losses")]
		public int HomeLosses { get; set; }

		[JsonProperty("home_ties")]
		public int HomeTies { get; set; }

		[JsonProperty("away_wins")]
		public int AwayWins { get; set; }

		[JsonProperty("away_losses")]
		public int AwayLosses { get; set; }

		[JsonProperty("away_ties")]
		public int AwayTies { get; set; }

		[JsonProperty("division_wins")]
		public int DivisionWins { get; set; }

		[JsonProperty("division_losses")]
		public int DivisionLosses { get; set; }

		[JsonProperty("division_ties")]
		public int DivisionTies { get; set; }
	}
}
