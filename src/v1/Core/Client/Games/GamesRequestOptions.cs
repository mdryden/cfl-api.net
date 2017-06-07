using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{
	public class GamesRequestOptions : //FilteredAndSortedRequestOptions<GamesFilterFactory, GamesSortFactory>
		IGamesRequestOptions,
		IHasFilters,
		IHasFluentFilters<FluentGamesFilterFactory>
		//IFluentGamesRequestOptions,
		//IAdditionalFluentGamesRequestOptions
	{

		private GamesFilterCreator filterCreator;
		private ISortCreator sortCreator;


		protected GamesRequestOptions(GamesFilterCreator filterCreator, ISortCreator sortCreator)
		{
			this.filterCreator = filterCreator;
			this.sortCreator = sortCreator;
		}
		
		public static IFluentGamesRequestOptions Create()
		{
			//return new GamesRequestOptions(new GamesFilterCreator(), new SortCreator());
		}

		FluentGamesFilterFactory IHasFluentFilters<FluentGamesFilterFactory>.GetFluentFilterFactory() => new FluentGamesFilterFactory(this, null);

		private List<string> filters = new List<string>();
		private List<string> sorts = new List<string>();

		//FluentGamesFilterFactory IFluentFilteredRequestOptions<FluentGamesFilterFactory>.WithFilter() => new FluentGamesFilterFactory(this, filterCreator);
		//FluentGamesSortFactory IFluentSortedRequestOptions<FluentGamesSortFactory>.WithSort() => new FluentGamesSortFactory(this, sortCreator);
		//FluentGamesFilterFactory IAdditionalFluentFilteredRequestOptions<FluentGamesFilterFactory>.AndFilter() => new FluentGamesFilterFactory(this, filterCreator);
		//FluentGamesSortFactory IAdditionalFluentSortedRequestOptions<FluentGamesSortFactory>.AndSort() => new FluentGamesSortFactory(this, sortCreator);

		void IHasFilters.AddFilter(string filter) => filters.Add(filter);
		void ISortedRequestOptions.AddSort(string sort) => sorts.Add(sort);
		IEnumerable<string> IHasFilters.GetFilters() => filters;
		IEnumerable<string> ISortedRequestOptions.GetSorts() => sorts;
		
	}

	public static class GamesRequestOptionsExtensions
	{
		//public static IAdditionalFluentRequestOptions<GamesFilterFactory, GamesSortFactory> Filter(this GamesRequestOptions options)
		//{
		//	return options;
		//}
		public static FluentGamesFilterFactory WithFilter(this IFluentGamesRequestOptions options)
		{
			return new FluentGamesFilterFactory(options, new GamesFilterCreator());
		}

		public static void Test()
		{
			IGamesRequestOptions options = GamesRequestOptions.Create().WithFilter().Team.EqualTo("SSK").AndSort().Attendance.Ascending();
		}
	}
}
