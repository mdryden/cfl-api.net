using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class PlayerSummary
	{
		[JsonProperty(PropertyName = "cfl_central_id")]
		public int CflCentralId { get; set; }

		[JsonProperty(PropertyName = "first_name")]
		public string FirstName { get; set; }

		[JsonProperty(PropertyName = "middle_name")]
		public string MiddleName { get; set; }

		[JsonProperty(PropertyName = "last_name")]
		public string LastName { get; set; }

		[JsonProperty(PropertyName = "birth_date")]
		public string BirthDate { get; set; }
	}
}
