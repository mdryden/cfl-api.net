using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerReceivingCaught : PlayerLeader
	{
		[JsonProperty("receiving_caught")]
		public int ReceivingCaught { get; set; }
	}
}
