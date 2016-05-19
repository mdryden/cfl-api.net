using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Seasons
	{
		[JsonIgnore]
		public int PlayerId { get; set; }

		[JsonProperty(PropertyName = "passing")]
		public IList<SeasonPassing> Passing { get; set; }

		[JsonProperty(PropertyName = "receiving")]
		public IList<SeasonReceiving> Receiving { get; set; }

		[JsonProperty(PropertyName = "rushing")]
		public IList<SeasonRushing> Rushing { get; set; }

		[JsonProperty(PropertyName = "defence")]
		public IList<SeasonDefence> Defence { get; set; }

		[JsonProperty(PropertyName = "field_goals")]
		public IList<SeasonFieldGoals> FieldGoals { get; set; }

		[JsonProperty(PropertyName = "punts")]
		public IList<SeasonPunts> Punts { get; set; }






	}
}
