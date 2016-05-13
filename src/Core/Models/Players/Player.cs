using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Player
	{
		[JsonProperty(PropertyName = "cfl_central_id")]
		public int CflCentralId { get; set; }

		[JsonProperty(PropertyName = "first_name")]
		public string FirstName { get; set; }

		[JsonProperty(PropertyName = "middle_name")]
		public string MiddleName { get; set; }

		[JsonProperty(PropertyName = "last_name")]
		public string LastName { get; set; }

		[JsonProperty(PropertyName = "birth_date")]
		public string BirthDate { get; set; }

		[JsonProperty(PropertyName = "birth_place")]
		public string BirthPlace { get; set; }

		[JsonProperty(PropertyName = "height")]
		public decimal Height { get; set; }

		[JsonProperty(PropertyName = "weight")]
		public int Weight { get; set; }

		[JsonProperty(PropertyName = "rookie_year")]
		public int RookieYear { get; set; }

		[JsonProperty(PropertyName = "foreign_player")]
		public bool ForeignPlayer { get; set; }

		[JsonProperty(PropertyName = "image_url")]
		public string ImageUrl { get; set; }

		[JsonProperty(PropertyName = "school")]
		public School School { get; set; }

		[JsonProperty(PropertyName = "position")]
		public Position Position { get; set; }

		[JsonProperty(PropertyName = "team")]
		public PlayerTeam Team { get; set; }

		[JsonProperty(PropertyName = "seasons")]
		public Seasons Seasons { get; set; }

		[JsonProperty(PropertyName = "game_by_game")]
		public GameByGame GameByGame { get; set; }
	}
}
