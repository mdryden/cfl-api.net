using System;
using System.Collections.Generic;
using System.Linq;

namespace mdryden.cflapi.v1.Client
{
	public abstract class RequestBuilder<TResponse, TApiResponse> : IRequestBuilder<TResponse, TApiResponse>
	{

		private int? pageNumber = null;
		private int? pageSize = null;
		protected List<string> Filters { get; } = new List<string>();
		protected List<string> Sorts { get; } = new List<string>();
		protected List<string> Includes { get; } = new List<string>();

		protected abstract string GetPath();

		protected void SetPageNumber(int pageNumber)
		{
			this.pageNumber = pageNumber;
		}

		protected void SetPageSize(int pageSize)
		{
			this.pageSize = pageSize;
		}

		public Request<TResponse, TApiResponse> GetRequest()
		{
			var parameters = string.Empty;

			if (pageNumber.HasValue)
			{
				parameters += $"&page[number]={pageNumber}";
			}

			if (pageSize.HasValue)
			{
				parameters += $"&page[size]={pageSize}";
			}

			foreach (var filter in Filters)
			{
				parameters += $"&{filter}";
			}

			if (Sorts.Count > 0)
			{
				parameters += $"&sort={string.Join(",", Sorts)}";
			}

			if (Includes.Count > 0)
			{
				var includesString = $"include={string.Join(",", Includes)}";
				parameters += $"&{includesString}";
			}

			var hasParams = !string.IsNullOrEmpty(parameters);
			var path = hasParams ? $"{GetPath()}?{parameters}" : GetPath();
			var request = new Request<TResponse, TApiResponse>(this, path);

			return request;
		}

		public abstract TResponse CleanResponse(TApiResponse apiResponse);
	}

	public abstract class RequestBuilder<TResponse> : RequestBuilder<TResponse, TResponse>
	{
		public override TResponse CleanResponse(TResponse apiResponse)
		{
			return apiResponse;
		}
	}

}
