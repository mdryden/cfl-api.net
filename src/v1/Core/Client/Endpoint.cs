using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public class Test
	{
		public void TestM()
		{
			//var games = Endpoint.Games.GetGames().WithFilter().DateStart()
		}
	}

	public static class Endpoint
	{
		public static IRequestClient RequestClient { get; private set; }


		public static void Setup(string apiKey, string host = "http://api.cfl.ca")
		{
			if (string.IsNullOrEmpty(apiKey))
			{
				throw new ArgumentNullException("apiKey");
			}

			if (string.IsNullOrEmpty(host))
			{
				throw new ArgumentNullException("host");
			}

			RequestClient = new RequestClient(apiKey, host);
		}

		public static void Setup(IRequestClient requestClient)
		{
			RequestClient = requestClient;
		}

		public static IGamesRequestFactory Games { get; set; } = new GamesRequestFactory();

		public static IPlayersRequestFactory Players { get; set; } = new PlayersRequestFactory();

		public static IStandingsRequestFactory Standings { get; set; } = new StandingsRequestFactory();

		public static ILeadersRequestFactory Leaders { get; set; } = new LeadersRequestFactory();

		public static ITeamLeadersRequestFactory TeamLeaders { get; set; } = new TeamLeadersRequestFactory();

		public static async Task<TResponse> InvokeAsync<TResponse, TApiResponse>(this IRequestBuilder<TResponse, TApiResponse> requestBuilder)
		{
			if (RequestClient == null)
			{
				throw new InvalidOperationException("Setup method must be called once before making API calls.");
			}

			var request = requestBuilder.GetRequest();
			return await request.InvokeAsync(RequestClient);
		}

		public static TResponse Invoke<TResponse, TApiResponse>(this IRequestBuilder<TResponse, TApiResponse> requestBuilder)
		{
			if (RequestClient == null)
			{
				throw new InvalidOperationException("Setup method must be called once before making API calls.");
			}

			var request = requestBuilder.GetRequest();
			return request.Invoke(RequestClient);
		}
	}
}
