using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class RosterPlayer : PlayerSummary
	{
		[JsonProperty("uniform")]
		public int Uniform { get; set; }

		[JsonProperty("is_starter")]
		public bool IsStarter { get; set; }

		[JsonProperty("is_inactive")]
		public bool IsInactive { get; set; }
	}
}
