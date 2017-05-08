using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class CoinToss
	{
		[JsonIgnore]
		public int GameId { get; set; }

		[JsonProperty("coin_toss_winner")]
		public string CoinTossWinner { get; set; }

		[JsonProperty("coin_toss_winner_election")]
		public string CoinTossWinnerElection { get; set; }

	}
}
