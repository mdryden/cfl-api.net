using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class Offence
	{
		[JsonProperty("passing_yards")]
		public IList<PlayerPassingYards> PassingYards { get; set; }

		[JsonProperty("passing_touchdowns")]
		public IList<PlayerPassingTouchdowns> PassingTouchdowns { get; set; }

		[JsonProperty("rushing_yards")]
		public IList<PlayerRushingYards> RushingYards { get; set; }

		[JsonProperty("rushing_touchdowns")]
		public IList<PlayerRushingTouchdowns> RushingTouchdowns { get; set; }

		[JsonProperty("receiving_yards")]
		public IList<PlayerReceivingYards> ReceivingYards { get; set; }

		[JsonProperty("receiving_touchdowns")]
		public IList<PlayerReceivingTouchdowns> ReceivingTouchdowns { get; set; }

		[JsonProperty("receiving_caught")]
		public IList<PlayerReceivingCaught> ReceivingCaught { get; set; }

		[JsonProperty("receiving_targeted")]
		public IList<PlayerReceivingTargeted> ReceivingTargeted { get; set; }
}
}
