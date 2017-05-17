using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Standings
{
	public class CrossoverContainer
	{
		[JsonProperty("divisions")]
		public CrossoverStandings Standings { get; set; }
	}
}
