using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class PlayerFieldGoalReturns : FieldGoalReturns
	{
		[JsonProperty(PropertyName = "player")]
		public PlayerSummary Player { get; set; }
	}
}
