using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class TeamConverts
	{
		[JsonIgnore]
		public int GameId { get; set; }

		[JsonIgnore]
		public int TeamId { get; set; }

		[JsonProperty("one_point_converts")]
		public TeamConverts1 OnePointConverts { get; set; }

		[JsonProperty("two_point_converts")]
		public TeamConverts2 TwoPointConverts { get; set; }
	}
}
