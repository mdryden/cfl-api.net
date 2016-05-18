using System;
using System.Collections.Generic;
using System.Diagnostics;
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

		public string LastRequestUrl { get; private set; }

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

		protected void AppendSorts(ref string url, IEnumerable<Sort> sorts)
		{
			var sortStrings = new List<string>();
			foreach (var sort in sorts)
			{
				sortStrings.Add(sort.GetSortString());
			}

			if (sortStrings.Count == 0)
			{
				return;
			}
			else
			{
				url += $"&sort={string.Join(",", sortStrings)}";
			}
		}

		protected void AppendParameter(ref string url, string parameter)
		{
			url += $"&{parameter}";
		}

		private DataContainer<T> GetResponse<T>(string url)
		{
			string response;

			using (var client = new WebClient())
			{
				LastRequestUrl = url;
				response = client.DownloadString(url);
			}

			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
			};

			return JsonConvert.DeserializeObject<DataContainer<T>>(response, settings);
		}
		
		public T GetItemResponse<T>(string url)
		{
			var response = GetResponse<T>(url);
			
			if (response == null || response.Data.Count() < 1)
			{
				throw new InvalidResponseException($"No items in api response", url);
			}

			return response.Data[0];
		}

		public T[] GetCollectionResponse<T>(string url)
		{
			var response = GetResponse<T>(url);

			return response != null ? response.Data : new T[] { };
		}


	}
}
