using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerSacks : PlayerLeader
	{
		[JsonProperty("sacks")]
		public int Sacks { get; set; }
	}
}
