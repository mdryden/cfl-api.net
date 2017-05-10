using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerFumblesRecoveries : PlayerLeader
	{
		[JsonProperty("fumbles_recoveries")]
		public int FumblesRecoveries { get; set; }
	}
}
