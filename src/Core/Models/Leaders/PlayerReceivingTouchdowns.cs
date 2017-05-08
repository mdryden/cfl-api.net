using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerReceivingTouchdowns : PlayerLeader
	{
		[JsonProperty("receiving_touchdowns")]
		public int ReceivingTouchdowns { get; set; }
	}
}
