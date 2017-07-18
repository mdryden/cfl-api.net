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

		protected void AppendFilters(ref string url, IEnumerable<string> filters)
		{
			foreach (var filter in filters)
			{
				url += $"&{filter}";
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

		private TContainer GetResponse<TContainer>(string url)
		{
			var token = RequestBuffer.CreateRequest();
			var delay = token.TimeToStart.Subtract(DateTime.Now);

			TContainer response;
			try
			{
				if (delay.TotalMilliseconds > 0)
				{
					var t = Task.Factory
						.StartNew(() => Task.Delay(delay).Wait())
						.ContinueWith((pre) => DoGetResponse<TContainer>(url));

					response = t.Result.Result;
				}
				else
				{
					response = DoGetResponse<TContainer>(url).Result;
				}
			}
			catch (WebException ex)
			{
				if (ex.Message.Contains("(429) Unknown"))
				{
					var t = Task.Factory
						.StartNew(() => Task.Delay(RequestBuffer.DelaySeconds).Wait())
						.ContinueWith((pre) => DoGetResponse<TContainer>(url));

					response = t.Result.Result;
				}
				else
				{
					throw;
				}
			}

			RequestBuffer.RemoveCompletedRequest(token);
			return response;
		}

		private async Task<TContainer> DoGetResponse<TContainer>(string url)
		{
			string response;

			using (var client = new WebClient())
			{
				LastRequestUrl = url;
				response = client.DownloadString(new Uri(url));
			}

			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
			};

			return await Task.Run(() => JsonConvert.DeserializeObject<TContainer>(response, settings));
		}

		protected T GetFirstItemResponse<T>(string url)
		{
			var response = GetResponse<DataArrayContainer<T>>(url);

			if (response == null || response.Data.Count() < 1)
			{
				throw new InvalidResponseException($"No items in api response", url);
			}

			return response.Data[0];
		}

		protected T GetItemResponse<T>(string url)
		{
			var response = GetResponse<DataContainer<T>>(url);

			if (response == null || response.Data == null)
			{
				throw new InvalidResponseException($"No item in api response", url);
			}

			return response.Data;
		}

		protected T[] GetCollectionResponse<T>(string url)
		{
			var response = GetResponse<DataArrayContainer<T>>(url);

			return response != null ? response.Data : new T[] { };
		}


	}
}
