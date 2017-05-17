using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Standings
{

	public class SeasonStandings
	{
		[JsonProperty("west")]
		public Division West { get; set; }

		[JsonProperty("east")]
		public Division East { get; set; }

	}
}
