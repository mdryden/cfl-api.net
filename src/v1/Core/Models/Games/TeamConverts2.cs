using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class TeamConverts2
	{
		[JsonProperty("attempts")]
		public int Attempts { get; set; }

		[JsonProperty("made")]
		public int Made { get; set; }
	}
}
