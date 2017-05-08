using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class DataContainer<T>
	{
		[JsonProperty("data")]
		public T Data { get; set; }

		[JsonProperty("errors")]
		public IList<object> Errors {  get; set; }

		[JsonProperty("meta")]
		public Meta Meta { get; set; }
	}
}
