﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Converts1
	{
		[JsonProperty("one_point_converts_attempts")]
		public int OnePointConvertsAttempts { get; set; }

		[JsonProperty("one_point_converts_made")]
		public int OnePointConvertsMade { get; set; }
	}
}
