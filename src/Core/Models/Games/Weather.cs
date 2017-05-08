using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Weather
	{
		[JsonProperty("temperature")]
		public int Temperature { get; set; }

		[JsonProperty("sky")]
		public string Sky { get; set; }

		[JsonProperty("wind_speed")]
		public string WindSpeed { get; set; }

		[JsonProperty("wind_direction")]
		public string WindDirection { get; set; }

		[JsonProperty("field_conditions")]
		public string FieldConditions { get; set; }
	}
}
