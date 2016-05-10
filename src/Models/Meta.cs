using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models
{
	public class Meta
	{
		[JsonProperty(PropertyName = "copyright")]
		public string Copyright { get; set; }
	}
}
