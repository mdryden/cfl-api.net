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

		//[JsonIgnore]
		//public int PlayerId
		//{
		//	get { return CflCentralId; }
		//	set { CflCentralId = value; }
		//}

		[JsonProperty("cfl_central_id")]
		public int CflCentralId { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("middle_name")]
		public string MiddleName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("birth_date")]
		public string BirthDate { get; set; }

		[JsonProperty("birth_place")]
		public string BirthPlace { get; set; }

		[JsonProperty("height")]
		public string Height { get; set; }

		[JsonProperty("weight")]
		public int Weight { get; set; }

		/// <summary>
		/// Changed from int to int? in v1.15
		/// </summary>
		[JsonProperty("rookie_year")]
		public int? RookieYear { get; set; }

		[JsonProperty("foreign_player")]
		public bool ForeignPlayer { get; set; }

		[JsonProperty("image_url")]
		public string ImageUrl { get; set; }

		[JsonProperty("school")]
		public School School { get; set; }

		[JsonProperty("position")]
		public Position Position { get; set; }

		[JsonProperty("team")]
		public PlayerTeam Team { get; set; }

		[JsonProperty("seasons")]
		public Seasons Seasons { get; set; }

		[JsonProperty("game_by_game")]
		public GameByGame GameByGame { get; set; }
	}
}
