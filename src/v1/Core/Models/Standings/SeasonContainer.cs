using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Standings
{
	public class SeasonContainer
	{
		[JsonProperty("divisions")]
		public SeasonStandings Standings { get; set; }
	}
}
