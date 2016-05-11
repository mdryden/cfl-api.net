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
		[JsonProperty(PropertyName = "passing")]
		public IList<Passing> Passing { get; set; }

		[JsonProperty(PropertyName = "receiving")]
		public IList<Receiving> Receiving { get; set; }

		[JsonProperty(PropertyName = "rushing")]
		public IList<Rushing> Rushing { get; set; }

		[JsonProperty(PropertyName = "defence")]
		public IList<Defence> Defence { get; set; }

		[JsonProperty(PropertyName = "field_goals")]
		public IList<FieldGoals> FieldGoals { get; set; }

		[JsonProperty(PropertyName = "punts")]
		public IList<Punts> Punts { get; set; }






	}
}
