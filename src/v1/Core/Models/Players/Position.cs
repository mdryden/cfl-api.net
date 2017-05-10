using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Position
	{

		[JsonProperty("position_id")]
		public int PositionId { get; set; }

		[JsonProperty("offence_defence_or_special")]
		public string OffenceDefenceOrSpecial { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

	}
}
