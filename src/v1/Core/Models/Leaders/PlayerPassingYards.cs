﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerPassingYards : PlayerLeader<PassingExtendedData>
	{
		[JsonProperty("passing_yards")]
		public int PassingYards { get; set; }
	}
}
