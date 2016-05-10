using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Game
	{

		[JsonProperty(PropertyName ="game_id")]
		public int GameId { get; set; }

		[JsonProperty(PropertyName = "date_start")]
		public DateTime DateStart { get; set; }

		[JsonProperty(PropertyName = "game_number")]
		public int GameNumber { get; set; }

		[JsonProperty(PropertyName = "week")]
		public int Week { get; set; }

		[JsonProperty(PropertyName = "season")]
		public int Season { get; set; }

		[JsonProperty(PropertyName = "attendance")]
		public int Attendance { get; set; }

		[JsonProperty(PropertyName = "event_type")]
		public EventType EventType { get; set; }

		[JsonProperty(PropertyName = "event_status")]
		public EventStatus EventStatus { get; set; }

		[JsonProperty(PropertyName = "venue")]
		public Venue Venue { get; set; }

		[JsonProperty(PropertyName = "weather")]
		public Weather Weather { get; set; }

		[JsonProperty(PropertyName = "coin_toss")]
		public CoinToss CoinToss { get; set; }

		[JsonProperty(PropertyName = "tickets_url")]
		public string TicketsUrl { get; set; }

		[JsonProperty(PropertyName = "team_1")]
		public Team Team1 { get; set; }

		[JsonProperty(PropertyName = "team_2")]
		public Team Team2 { get; set; }

		[JsonProperty(PropertyName = "boxscore")]
		public Boxscore Boxscore { get; set; }

		[JsonProperty(PropertyName = "play_by_play")]
		public IList<Play> PlayByPlay { get; set; }
	}
}
