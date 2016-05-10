using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class BoxscorePlayers
	{
		[JsonProperty(PropertyName = "passing")]
		public IList<PlayerPassing> Passing { get; set; }

		[JsonProperty(PropertyName = "rushing")]
		public IList<PlayerRushing> Rushing { get; set; }

		[JsonProperty(PropertyName = "receiving")]
		public IList<PlayerReceiving> Receiving { get; set; }

		[JsonProperty(PropertyName = "punts")]
		public IList<PlayerPunts> Punts { get; set; }

		[JsonProperty(PropertyName = "punt_returns")]
		public IList<PlayerPuntReturns> PuntReturns { get; set; }

		[JsonProperty(PropertyName = "kick_returns")]
		public IList<PlayerKickReturns> KickReturns { get; set; }

		[JsonProperty(PropertyName = "field_goal_returns")]
		public IList<PlayerFieldGoalReturns> FieldGoalReturns { get; set; }

		[JsonProperty(PropertyName = "kicking")]
		public IList<PlayerKicking> Kicking { get; set; }

		[JsonProperty(PropertyName = "defence")]
		public IList<PlayerDefence> Defence { get; set; }
	}
}
