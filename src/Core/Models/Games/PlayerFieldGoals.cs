using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class PlayerFieldGoals : FieldGoals
	{
		[JsonIgnore]
		public int GameId { get; set; }

		[JsonIgnore]
		public int PlayerId
		{
			get { return Player.CflCentralId; }
			set { Player.CflCentralId = value; }
		}

		[JsonProperty("player")]
		public PlayerSummary Player { get; set; }

		/// <summary>
		/// Added in v1.15
		/// </summary>
		[JsonProperty("field_goal_missed_list")]
		string FieldGoalMissedList { get; set; }


	}
}
