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
using System.Threading;

namespace mdryden.cflapi.v1.Client
{
	public class RequestClient : IRequestClient
	{
		private string apiKey;
		private string host;

		public RequestClient(string apiKey, string host)
		{
			this.apiKey = apiKey;
			this.host = host;
		}

		public string LastRequestUrl { get; private set; }

		public string LastResponse { get; private set; }


		public string GetRequestUrl(string path)
		{
			return $"{host}{path}";
		}
		
		public async Task<Response> InvokeAsync(string path)
		{
			var url = GetRequestUrl(path);
			LastRequestUrl = url;

			var token = RequestBuffer.CreateRequest();
			var delay = token.TimeToStart.Subtract(DateTime.Now);

			Response response;

			try
			{
				if (delay.TotalMilliseconds > 0)
				{
					var t = Task.Factory
						.StartNew(() => Task.Delay(delay).Wait())
						.ContinueWith((pre) => GetResponseAsync(url));

					response = t.Result.Result;
				}
				else
				{
					response = GetResponseAsync(url).Result;
				}
			}
			catch (WebException ex)
			{
				if (ex.Message.Contains("(429) Unknown"))
				{
					var t = Task.Factory
						.StartNew(() => Task.Delay(RequestBuffer.DelaySeconds).Wait())
						.ContinueWith((pre) => GetResponseAsync(url));

					response = await t.Result;
				}
				else
				{
					throw CreateException(url, ex);
				}
			}
			catch (Exception ex)
			{
				throw CreateException(url, ex);
			}

			RequestBuffer.RemoveCompletedRequest(token);
			return response;
		}
		public Response Invoke(string path)
		{
			var url = GetRequestUrl(path);
			LastRequestUrl = url;
			
			Response response;

			try
			{
				response = GetResponse(url);

			}
			catch (WebException ex)
			{
				if (ex.Message.Contains("(429) Unknown"))
				{
					Thread.Sleep(RequestBuffer.DelaySeconds);

					response = GetResponse(url);
				}
				else
				{
					throw CreateException(url, ex);
				}
			}
			catch (Exception ex)
			{
				throw CreateException(url, ex);
			}
			
			return response;
		}

		private WebException CreateException(string url, Exception innerException)
		{
			return new WebException($"Api call failed for url: {AppendKey(url, "<key>")} with response {innerException.Message}", innerException);
		}

		private string AppendKey(string url, string key)
		{
			var hasParams = url.Contains("?");
			var separator = hasParams ? "&" : "?";

			return $"{url}{separator}key={key}";
		}

		private async Task<Response> GetResponseAsync(string url)
		{
			string response;

			using (var client = new WebClient())
			{
				LastRequestUrl = url;
				response = await client.DownloadStringTaskAsync(new Uri(AppendKey(url, apiKey)));
				LastResponse = response;
			}

			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
			};

			return new Response(response);
		}

		private Response GetResponse(string url)
		{
			string response;

			using (var client = new WebClient())
			{
				LastRequestUrl = url;
				response = client.DownloadString(new Uri(AppendKey(url, apiKey)));
				LastResponse = response;
			}

			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
			};

			return new Response(response);
		}
	}
}
