using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class PlayPlayers
	{
		[JsonIgnore]
		public int PlayId { get; set; }

		[JsonProperty("quarterback")]
		public PlayerSummary Quarterback { get; set; }

		[JsonProperty("ball_carrier")]
		public PlayerSummary BallCarrier { get; set; }

		[JsonProperty("primary_defender")]
		public PlayerSummary PrimaryDefender { get; set; }
	}
}
