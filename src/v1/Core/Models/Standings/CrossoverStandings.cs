using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Standings
{

	public class CrossoverStandings : SeasonStandings
	{
		[JsonProperty("crossover")]
		public Division Crossover { get; set; }

		[JsonProperty("out_of_playoffs")]
		public Division OutOfPlayoffs { get; set; }

	}
}
