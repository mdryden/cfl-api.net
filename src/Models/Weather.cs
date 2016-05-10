using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Weather
	{
		[JsonProperty(PropertyName = "temperature")]
		public int Temperature { get; set; }

		[JsonProperty(PropertyName = "sky")]
		public string Sky { get; set; }

		[JsonProperty(PropertyName = "wind_speed")]
		public string WindSpeed { get; set; }

		[JsonProperty(PropertyName = "wind_direction")]
		public string WindDirection { get; set; }

		[JsonProperty(PropertyName = "field_conditions")]
		public string FieldConditions { get; set; }
	}
}
