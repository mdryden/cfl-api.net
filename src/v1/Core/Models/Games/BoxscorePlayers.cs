using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class BoxscorePlayers
	{
		[JsonIgnore]
		public int GameId { get; set; }
		
		[JsonIgnore]
		public int TeamId { get; set; }

		[JsonProperty("passing")]
		public IList<PlayerPassing> Passing { get; set; }

		[JsonProperty("rushing")]
		public IList<PlayerRushing> Rushing { get; set; }

		[JsonProperty("receiving")]
		public IList<PlayerReceiving> Receiving { get; set; }

		[JsonProperty("punts")]
		public IList<PlayerPunts> Punts { get; set; }

		[JsonProperty("punt_returns")]
		public IList<PlayerPuntReturns> PuntReturns { get; set; }

		[JsonProperty("kick_returns")]
		public IList<PlayerKickReturns> KickReturns { get; set; }

		[JsonProperty("field_goals")]
		public IList<PlayerFieldGoals> FieldGoals { get; set; }

		[JsonProperty("field_goal_returns")]
		public IList<PlayerFieldGoalReturns> FieldGoalReturns { get; set; }

		[JsonProperty("kicking")]
		public IList<PlayerKicking> Kicking { get; set; }

		[JsonProperty("one_point_converts")]
		public IList<PlayerConverts1> OnePointConverts { get; set; }

		[JsonProperty("two_point_converts")]
		public IList<PlayerConverts2> TwoPointConverts { get; set; }

		[JsonProperty("defence")]
		public IList<PlayerDefence> Defence { get; set; }
	}
}
