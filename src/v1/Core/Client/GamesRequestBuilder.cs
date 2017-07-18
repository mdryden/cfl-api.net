using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models.Games;

namespace mdryden.cflapi.v1.Client
{

	public class GamesRequestBuilder : RequestBuilder<IList<Game>>, IGamesRequestBuilder
	{
		private int? season;

		public IGamesRequestBuilder Season(int season)
		{
			this.season = season;
			return this;
		}

		public IGamesRequestBuilder PageNumber(int pageNumber)
		{
			SetPageNumber(pageNumber);
			return this;
		}

		public IGamesRequestBuilder PageSize(int pageSize)
		{
			SetPageSize(pageSize);
			return this;
		}

		public void AddFilter(string filter) => Filters.Add(filter);
		public void AddSort(string sort) => Sorts.Add(sort);

		public GamesFilterFactory<IGamesRequestBuilder> WithFilter() => new GamesFilterFactory<IGamesRequestBuilder>(this); 

		public GamesSortFactory<IGamesRequestBuilder> WithSort() => new GamesSortFactory<IGamesRequestBuilder>(this); 

		protected override string GetPath()
		{
			var path = season != null ? $"/v1/games/{season}" : "/v1/games";
			return path;
		}
	}
}
