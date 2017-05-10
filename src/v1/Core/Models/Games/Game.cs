using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Game
	{

		[JsonProperty(PropertyName ="game_id")]
		public int GameId { get; set; }

		[JsonProperty("date_start")]
		public DateTime DateStart { get; set; }

		[JsonProperty("game_number")]
		public int GameNumber { get; set; }

		[JsonProperty("week")]
		public int Week { get; set; }

		[JsonProperty("season")]
		public int Season { get; set; }

		[JsonProperty("attendance")]
		public int Attendance { get; set; }

		[JsonProperty("event_type")]
		public EventType EventType { get; set; }

		[JsonProperty("event_status")]
		public EventStatus EventStatus { get; set; }

		[JsonProperty("venue")]
		public Venue Venue { get; set; }

		[JsonProperty("weather")]
		public Weather Weather { get; set; }

		[JsonProperty("coin_toss")]
		public CoinToss CoinToss { get; set; }

		[JsonProperty("tickets_url")]
		public string TicketsUrl { get; set; }

		[JsonProperty("team_1")]
		public Team Team1 { get; set; }

		[JsonProperty("team_2")]
		public Team Team2 { get; set; }

		[JsonProperty("boxscore")]
		public Boxscore Boxscore { get; set; }

		[JsonProperty("play_by_play")]
		public IList<Play> PlayByPlay { get; set; }

		/// <summary>
		/// Added in v1.05
		/// </summary>
		[JsonProperty("rosters")]
		public Rosters Rosters { get; set; }
	}
}
