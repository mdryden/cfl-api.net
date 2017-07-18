using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class GamesSortFactory<TRequest> : SortFactory<TRequest> where TRequest : ISortedRequest
	{
	
		public static ISortCreator SortCreator { get; set; }

		public GamesSortFactory(TRequest request)
			: base(request)
		{
		}

		protected override ISortCreator GetSortCreator()
		{
			return SortCreator;
		}

		public TRequest DateStart(SortOrder order) => CreateSortAndReturnOptions("date_start", order); 
		public TRequest Season(SortOrder order) => CreateSortAndReturnOptions("season", order);
		public TRequest Week(SortOrder order) => CreateSortAndReturnOptions("week", order); 
		public TRequest Temperature(SortOrder order) => CreateSortAndReturnOptions("temperature", order); 
		public TRequest Attendance(SortOrder order) => CreateSortAndReturnOptions("attendance", order); 
		public TRequest Team1(SortOrder order) => CreateSortAndReturnOptions("team1", order); 
		public TRequest Team2(SortOrder order) => CreateSortAndReturnOptions("team2", order); 

	}
}
