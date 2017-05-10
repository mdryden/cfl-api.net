using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Offence
	{
		[JsonProperty("offence_possession_time")]
		public string OffensePossessionTime { get; set; }

		/// <summary>
		/// Added in v1.16
		/// </summary>
		[JsonProperty("downs")]
		public IList<OffenseDowns> Downs { get; set; }
	}
}
