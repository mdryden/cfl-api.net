//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using mdryden.cflapi.v1.Client.Fluent;

//namespace mdryden.cflapi.v1.Client.Games
//{
//	public class GamesRequestOptions : ISortedRequest, IFilteredRequest// : IGamesRequestOptions
//	{

//		public GamesRequestOptions()
//		{

//		}
		
//		public IList<string> Sorts { get; } = new List<string>();
//		public IList<string> Filters { get; } = new List<string>();

//		public GamesSortFactory WithSort()
//		{
//			return new GamesSortFactory(this, new SortCreator());
//		}

//		public GamesFilterFactory WithFilter()
//		{
//			return new GamesFilterFactory(this, new GamesFilterCreator());
//		}
//	}
	
//	public static class GamesRequestOptionsExtensions
//	{
//		//public static IAdditionalFluentRequestOptions<GamesFilterFactory, GamesSortFactory> Filter(this GamesRequestOptions options)
//		//{
//		//	return options;
//		//}
//		//public static FluentGamesFilterFactory WithFilter(this IFluentGamesRequestOptions options)
//		//{
//		//	return new FluentGamesFilterFactory(options, new GamesFilterCreator());
//		//}

//		public static void Test()
//		{
//			//IGamesRequestOptions options = new GamesRequestOptions().WithFilter().Team.EqualTo("SSK").AndSort().Attendance.Ascending();
//			GamesRequestOptions options2 = new GamesRequestOptions().WithSort().DateStart(SortOrder.Ascending).WithFilter().DateStart(GameFilterOperators.EqualTo, DateTime.Now);
//			new GamesRequestOptions().WithSort().DateStart(SortOrder.Ascending).WithFilter().Attendance(GameFilterOperators.EqualTo, 10000);
//			//GamesRequestOptions options = new GamesRequestOptions().WithSort().DateStart.Ascending().WithFilter().GameId.EqualTo(1);
//			//GamesRequestOptions options = new GamesRequestOptions().With().Sort().DateStart(SortOrder.Ascending);

//		}
//	}
//}
