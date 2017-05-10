using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class LineScore
	{
		[JsonIgnore]
		public int GameId { get; set; }
		
		[JsonProperty("quarter")]
		public Quarters Quarter { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }

	}
}
