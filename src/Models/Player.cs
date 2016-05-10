using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Player : PlayerSummary
	{
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
	}
}
