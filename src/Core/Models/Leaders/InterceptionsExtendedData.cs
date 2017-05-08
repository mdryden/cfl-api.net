using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class InterceptionsExtendedData
	{
		[JsonProperty("interceptions_yards")]
		public string InterceptionsYards { get; set; }

		[JsonProperty("interceptions_long")]
		public string InterceptionsLong { get; set; }

		[JsonProperty("interceptions_touchdowns")]
		public string InterceptionsTouchdowns { get; set; }

		[JsonProperty("interceptions_touchdowns_long")]
		public string Interceptions_Touchdowns_Long { get; set; }
	}
}
