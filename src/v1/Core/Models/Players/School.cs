using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class School
	{
		[JsonProperty("school_id")]
		public int SchoolId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
