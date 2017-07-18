//using mdryden.cflapi.v1.Client.Games;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.Fluent
//{
//	public class FluentGamesSortFactory : FluentSortFactory<GamesRequestOptions>
//	{
	
//		public FluentGamesSortFactory(GamesRequestOptions options, ISortCreator creator)
//			: base(options, creator)
//		{
//		}

//		public GamesRequestOptions DateStart(SortOrder order) => CreateSortAndReturnOptions("date_start", order); 
//		public GamesRequestOptions Season(SortOrder order) => CreateSortAndReturnOptions("season", order);
//		public GamesRequestOptions Week(SortOrder order) => CreateSortAndReturnOptions("week", order); 
//		public GamesRequestOptions Temperature(SortOrder order) => CreateSortAndReturnOptions("temperature", order); 
//		public GamesRequestOptions Attendance(SortOrder order) => CreateSortAndReturnOptions("attendance", order); 
//		public GamesRequestOptions Team1(SortOrder order) => CreateSortAndReturnOptions("team1", order); 
//		public GamesRequestOptions Team2(SortOrder order) => CreateSortAndReturnOptions("team2", order); 

//	}
//}
