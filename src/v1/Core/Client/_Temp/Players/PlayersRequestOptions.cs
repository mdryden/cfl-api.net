//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.Players
//{
//	public class PlayersRequestOptions :
//		IPlayersRequestOptions,
//		IFluentPlayersRequestOptions,
//		IAdditionalFluentPlayersRequestOptions
//	{

//		private PlayersFilterCreator filterCreator;
//		private PlayersHeightFilterCreator heightFilterCreator;
//		private ISortCreator sortCreator;

//		protected PlayersRequestOptions(PlayersFilterCreator filterCreator, PlayersHeightFilterCreator heightFilterCreator, ISortCreator sortCreator)
//		{
//			this.filterCreator = filterCreator;
//			this.heightFilterCreator = heightFilterCreator;
//			this.sortCreator = sortCreator;
//		}

//		public static IFluentPlayersRequestOptions Create()
//		{
//			return new PlayersRequestOptions(new PlayersFilterCreator(), new PlayersHeightFilterCreator(), new SortCreator());
//		}


//		private List<string> filters = new List<string>();
//		private List<string> sorts = new List<string>();

//		FluentPlayersFilterFactory IFluentFilteredRequestOptions<FluentPlayersFilterFactory>.WithFilter() => new FluentPlayersFilterFactory(this, filterCreator, heightFilterCreator);
//		FluentPlayersSortFactory IFluentSortedRequestOptions<FluentPlayersSortFactory>.WithSort() => new FluentPlayersSortFactory(this, sortCreator);
//		FluentPlayersFilterFactory IAdditionalFluentFilteredRequestOptions<FluentPlayersFilterFactory>.AndFilter() => new FluentPlayersFilterFactory(this, filterCreator, heightFilterCreator);
//		FluentPlayersSortFactory IAdditionalFluentSortedRequestOptions<FluentPlayersSortFactory>.AndSort() => new FluentPlayersSortFactory(this, sortCreator);

//		void IFilteredRequest.AddFilter(string filter) => filters.Add(filter);
//		void ISortedRequest.AddSort(string sort) => sorts.Add(sort);
//		IEnumerable<string> IFilteredRequest.GetFilters() => filters;
//		IEnumerable<string> ISortedRequest.GetSorts() => sorts;
//	}
//}
