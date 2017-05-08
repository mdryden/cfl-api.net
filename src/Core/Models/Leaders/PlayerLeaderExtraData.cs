using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerLeader<TExtendedData> : PlayerLeader
	{
		[JsonProperty("extended_data")]
		public TExtendedData ExtendedData;

	}
}
