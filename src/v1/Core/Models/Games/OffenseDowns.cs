﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class OffenseDowns
	{
		[JsonProperty("abbreviation")]
		public int Down { get; set; }

		[JsonProperty("attempts")]
		public int Attempts { get; set; }

		[JsonProperty("yards")]
		public int Yards { get; set; }
	}
}