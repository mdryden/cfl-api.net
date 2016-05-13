using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class EventType
	{

		[JsonProperty(PropertyName = "event_type_id")]
		public int EventTypeId { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }


	}
}
