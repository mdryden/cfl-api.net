using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class School
	{
		[JsonProperty(PropertyName = "school_id")]
		public int SchoolId { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }
	}
}
