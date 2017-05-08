using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class TeamDefence : Defence
	{
		[JsonIgnore]
		public int GameId { get; set; }

		[JsonIgnore]
		public int TeamId { get; set; }

		/// <summary>
		/// Added in v1.20
		/// </summary>
		[JsonProperty("defensive_touchdowns")]
		public int DefensiveTouchdowns { get; set; }

		/// <summary>
		/// Added in v1.20
		/// </summary>
		[JsonProperty("defensive_safeties")]
		public int DefensiveSafeties { get; set; }
	}
}
