using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class PlayerSummary
	{
		[JsonProperty("cfl_central_id")]
		public int CflCentralId { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("middle_name")]
		public string MiddleName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("birth_date")]
		public string BirthDate { get; set; }
	}
}
