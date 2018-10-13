using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class PlayerGames
	{
		[JsonIgnore]
		public int PlayerGamesId { get; set; }

		[JsonProperty("passing")]
		public IList<Passing> Passing { get; set; }

		[JsonProperty("receiving")]
		public IList<Receiving> Receiving { get; set; }

		[JsonProperty("rushing")]
		public IList<Rushing> Rushing { get; set; }

		[JsonProperty("defence")]
		public IList<Defence> Defence { get; set; }

		[JsonProperty("field_goals")]
		public IList<FieldGoals> FieldGoals { get; set; }

		[JsonProperty("punts")]
		public IList<Punts> Punts { get; set; }

	}
}
