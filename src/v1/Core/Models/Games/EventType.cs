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

		[JsonProperty("event_type_id")]
		public int EventTypeId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Added in v1.21
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

	}
}
