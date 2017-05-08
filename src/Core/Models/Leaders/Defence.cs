using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class Defence
	{
		[JsonProperty("tackles_defensive")]
		public IList<PlayerTacklesDefensive> TacklesDefensive { get; set; }

		[JsonProperty("sacks")]
		public IList<PlayerSacks> Sacks { get; set; }

		[JsonProperty("interceptions")]
		public IList<PlayerInterceptions> Interceptions { get; set; }

		[JsonProperty("fumbles_forced")]
		public IList<PlayerFumblesForced> FumblesForced { get; set; }

		[JsonProperty("fumbles_recoveries")]
		public IList<PlayerFumblesRecoveries> FumblesRecoveries { get; set; }
	}
}
