using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerFieldGoals : PlayerLeader<FieldGoalsExtendedData>
	{
		[JsonProperty("field_goals")]
		public int FieldGoals { get; set; }
	}
}
