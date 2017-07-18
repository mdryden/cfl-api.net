using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using mdryden.cflapi.v1.Models.Players;
using Newtonsoft.Json;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace mdryden.cflapi.v1.Client
{
	public class Response
	{
		private string responseString;

		public Response(string responseString)
		{
			this.responseString = responseString;
		}

		public T GetResponse<T>()
		{
			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
			};

			var container = JsonConvert.DeserializeObject<DataContainer<T>>(responseString, settings);
			return container.Data;
		}

	}
}
