using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class EventStatus
	{
		[JsonProperty(PropertyName = "event_status_id")]
		public int EventStatusId { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "is_active")]
		public bool IsActive { get; set; }

		[JsonProperty(PropertyName = "quarter")]
		public int Quarter { get; set; }

		[JsonProperty(PropertyName = "minutes")]
		public int Minutes { get; set; }

		[JsonProperty(PropertyName = "seconds")]
		public int Seconds { get; set; }

		[JsonProperty(PropertyName = "down")]
		public int Down { get; set; }

		[JsonProperty(PropertyName = "yards_to_go")]
		public int YardsToGo { get; set; }

	}
}
