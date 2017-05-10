using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	static class RequestBuffer
	{

		public const int RequestsPerMinute = 30;
		public const int DelaySeconds = 62;

		private static List<RequestToken> requestsInLastLimitPeriod = new List<RequestToken>();

		private static object _lock = new object();

		public static void RemoveCompletedRequest(RequestToken request)
		{
			lock (_lock)
			{
				request.TimeCompleted = DateTime.Now;
				ClearStaleTokens();
			}
		}

		private static void ClearStaleTokens()
		{
			requestsInLastLimitPeriod.RemoveAll(r => r.TimeCompleted.AddSeconds(DelaySeconds) < DateTime.Now);
		}

		public static RequestToken CreateRequest()
		{
			lock (_lock)
			{
				ClearStaleTokens();
				var token = new RequestToken();
				if (requestsInLastLimitPeriod.Count() < RequestsPerMinute)
				{
					token.TimeToStart = DateTime.Now;
				}
				else
				{
					token.TimeToStart = requestsInLastLimitPeriod[0].TimeToStart.AddSeconds(DelaySeconds);
				}
				requestsInLastLimitPeriod.Add(token);

				return token;
			}
		}

	}
}
