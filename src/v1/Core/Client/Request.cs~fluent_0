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

namespace mdryden.cflapi.v1.Client
{
	public class Request<TResponse, TApiResponse> //: IRequest
	{
		private IRequestBuilder<TResponse, TApiResponse> requestBuilder;
		private string path;

		public Request(IRequestBuilder<TResponse, TApiResponse> requestBuilder, string path)
		{
			this.requestBuilder = requestBuilder;
			this.path = path;
		}
				
		public async Task<TResponse> InvokeAsync(IRequestClient client)
		{
			try
			{ 
				var response = await client.InvokeAsync(path);
				var apiResponse = response.GetResponse<TApiResponse>();
				return requestBuilder.CleanResponse(apiResponse);
			}
			catch (Exception ex)
			{
				throw CreateException(ex);
			}
		}

		public TResponse Invoke(IRequestClient client)
		{
			try
			{
				var response = client.Invoke(path);
				var apiResponse = response.GetResponse<TApiResponse>();
				return requestBuilder.CleanResponse(apiResponse);
			}
			catch (Exception ex)
			{
				throw CreateException(ex);
			}
		}
		
		private WebException CreateException(Exception innerException)
		{
			return new WebException($"Api call failed for path: {path} with response {innerException.Message}", innerException);
		}
	}
}
