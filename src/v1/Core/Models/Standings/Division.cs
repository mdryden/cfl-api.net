using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Standings
{
	public class Division
	{
		[JsonProperty("division_id")]
		public int DivisionId { get; set; }

		[JsonProperty("division_name")]
		public string DivisionName { get; set; }

		[JsonProperty("division_slug")]
		public string DivisionSlug { get; set; }

		[JsonProperty("standings")]
		public DivisionStanding[] Standings { get; set; }
	}
}
