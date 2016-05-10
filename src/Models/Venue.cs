using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Venue
	{
		[JsonProperty(PropertyName = "venue_id")]
		public int VenueId { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }
	}
}
