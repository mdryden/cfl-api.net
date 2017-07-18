//using System;
//using mdryden.cflapi.v1.Client.Games;

//namespace mdryden.cflapi.v1.Client.Fluent
//{
//	public class FluentGamesRequestOptions : ISortableWithFilters<GamesRequestOptions, FluentGamesSortFactory, FluentGamesFilterFactory>
//	{



//		//private GamesFilterCreator filterCreator;
//		//private ISortCreator sortCreator;


//		//public FluentGamesRequestOptions(GamesFilterCreator filterCreator, ISortCreator sortCreator)
//		//{
//		//	this.filterCreator = filterCreator;
//		//	this.sortCreator = sortCreator;
//		//}


//		//public FluentGamesFilterFactory WithFilter() => new FluentGamesFilterFactory(this, filterCreator);
//		//public FluentGamesSortFactory WithSort() => new FluentGamesSortFactory(this, sortCreator);
//		//FluentGamesFilterFactory IAdditionalFluentFilteredRequestOptions<FluentGamesFilterFactory>.AndFilter() => new FluentGamesFilterFactory(this, filterCreator);
//		//FluentGamesSortFactory IAdditionalFluentSortedRequestOptions<FluentGamesSortFactory>.AndSort() => new FluentGamesSortFactory(this, sortCreator);

//		private GamesRequestOptions options;

//		public FluentGamesRequestOptions(GamesRequestOptions options)
//		{
//			this.options = options;
//		}

//		GamesRequestOptions IFluentRequestOptions<GamesRequestOptions>.Options => options;
//	}
//}
