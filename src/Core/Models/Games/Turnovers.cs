using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Turnovers
	{
		[JsonProperty("fumbles")]
		public int Fumbles { get; set; }

		[JsonProperty("interceptions")]
		public int Interceptions { get; set; }

		[JsonProperty("downs")]
		public int Downs { get; set; }
	}
}
