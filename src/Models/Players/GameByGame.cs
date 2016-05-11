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
		[JsonProperty(PropertyName = "passing")]
		public IList<GamePassing> Passing { get; set; }

		[JsonProperty(PropertyName = "receiving")]
		public IList<GameReceiving> Receiving { get; set; }

		[JsonProperty(PropertyName = "rushing")]
		public IList<GameRushing> Rushing { get; set; }

		[JsonProperty(PropertyName = "defence")]
		public IList<GameDefence> Defence { get; set; }

		[JsonProperty(PropertyName = "field_goals")]
		public IList<GameFieldGoals> FieldGoals { get; set; }

		[JsonProperty(PropertyName = "punts")]
		public IList<GamePunts> Punts { get; set; }
	}
}
