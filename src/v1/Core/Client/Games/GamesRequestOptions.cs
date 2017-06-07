using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{
	public class GamesRequestOptions : //FilteredAndSortedRequestOptions<GamesFilterFactory, GamesSortFactory>
		//IGamesRequestOptions,
		//IHasFilters,
		//IHasFluentFilters<FluentGamesFilterFactory>
		//IFluentGamesRequestOptions,
		//IAdditionalFluentGamesRequestOptions
		IHasFluentFilters<IGamesFilterFactory>
	{

		private List<string> filters = new List<string>();
		private List<string> sorts = new List<string>();

		private IGamesFilterFactory filterFactory;
		private ISortCreator sortCreator;


		//protected GamesRequestOptions(GamesFilterCreator filterCreator, ISortCreator sortCreator)
		//{
		//	this.filterCreator = filterCreator;
		//	this.sortCreator = sortCreator;
		//}
		
		public static GamesRequestOptions Create()
		{
			//return new GamesRequestOptions(new GamesFilterCreator(), new SortCreator());
		}
		
		IGamesFilterFactory IHasFilters<IGamesFilterFactory>.FilterFactory { get => filterFactory; set => filterFactory = value; }


		//FluentGamesFilterFactory IFluentFilteredRequestOptions<FluentGamesFilterFactory>.WithFilter() => new FluentGamesFilterFactory(this, filterCreator);
		//FluentGamesSortFactory IFluentSortedRequestOptions<FluentGamesSortFactory>.WithSort() => new FluentGamesSortFactory(this, sortCreator);
		//FluentGamesFilterFactory IAdditionalFluentFilteredRequestOptions<FluentGamesFilterFactory>.AndFilter() => new FluentGamesFilterFactory(this, filterCreator);
		//FluentGamesSortFactory IAdditionalFluentSortedRequestOptions<FluentGamesSortFactory>.AndSort() => new FluentGamesSortFactory(this, sortCreator);

		void IHasFilters<IGamesFilterFactory>.AddFilter(string filter) => filters.Add(filter);
		//void ISortedRequestOptions.AddSort(string sort) => sorts.Add(sort);
		IEnumerable<string> IHasFilters<IGamesFilterFactory>.GetFilters() => filters;
		

	}

	public static class GamesRequestOptionsExtensions
	{
		//public static IAdditionalFluentRequestOptions<GamesFilterFactory, GamesSortFactory> Filter(this GamesRequestOptions options)
		//{
		//	return options;
		//}

		public static FluentFilterFactory<TFilterFactory> WithFilter<TFilterFactory>(this IHasFilters<TFilterFactory> options)
		{
			return new FluentFilterFactory<TFilterFactory>(o)
		}

		public static FluentFilterCreator<T, TRequestOptions> EqualTo<T, TRequestOptions>(this FluentFilterFactory<TRequestOptions> filterCreator)
		{
			filterCreator
		}

		//public static object WithFilter(this IHasFilters options)
		//{
		//	return options.h
		//}

		public static void Test()
		{
			//IGamesRequestOptions options = GamesRequestOptions.Create().WithFilter().Team.EqualTo("SSK").AndSort().Attendance.Ascending();
			var options = new GamesRequestOptions().WithFilter().GameId.
		}
	}
}
