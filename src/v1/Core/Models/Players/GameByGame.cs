using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class GameByGame
	{
		[JsonIgnore]
		public int PlayerId { get; set; }

		[JsonProperty("passing")]
		public IList<GamePassing> Passing { get; set; }

		[JsonProperty("receiving")]
		public IList<GameReceiving> Receiving { get; set; }

		[JsonProperty("rushing")]
		public IList<GameRushing> Rushing { get; set; }

		[JsonProperty("defence")]
		public IList<GameDefence> Defence { get; set; }

		[JsonProperty("field_goals")]
		public IList<GameFieldGoals> FieldGoals { get; set; }

		[JsonProperty("punts")]
		public IList<GamePunts> Punts { get; set; }

		/// <summary>
		/// Added in v1.17
		/// </summary>
		[JsonProperty("punt_returns")]
		public IList<GamePuntReturns> PuntReturns { get; set; }

		/// <summary>
		/// Added in v1.17
		/// </summary>
		[JsonProperty("kickoff_returns")]
		public IList<GameKickoffReturns> KickoffReturns { get; set; }

		/// <summary>
		/// Added in v1.17
		/// </summary>
		[JsonProperty("missed_fg_returns")]
		public IList<GameMissedFieldGoalReturns> MissedFieldGoalReturns { get; set; }

		[JsonProperty("kickoffs")]
		public IList<GameKickoffs> Kickoffs { get; set; }
	}
}
