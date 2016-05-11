using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Client.Games;
using mdryden.cflapi.v1.Client.Players;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using mdryden.cflapi.v1.Models.Players;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Client
{
	public class ClientBase
	{
		private string apiKey;
		private string host;

		public ClientBase(string apiKey, string host = "http://api.cfl.ca")
		{
			this.apiKey = apiKey;
			this.host = host;
		}

		protected string GetUrl(string path)
		{
			return $"{host}{path}?key={apiKey}";			
        }

		protected void AppendFilters(ref string url, IEnumerable<Filter> filters)
		{
			foreach (var filter in filters)
			{
				url += $"&{filter.GetFilterString()}";				
			}
		}

		protected void AppendParameter(ref string url, string parameter)
		{
			url += $"&{parameter}";
		}
		
		public T GetResponse<T>(string url)
		{
			string response;

			using (var client = new WebClient())
			{
				response = client.DownloadString(url);
			}

			return JsonConvert.DeserializeObject<T>(response);
		}

		
		
	}
}
