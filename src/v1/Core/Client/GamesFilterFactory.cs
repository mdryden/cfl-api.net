using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{


	
	public class GamesFilterFactory<TRequest> : FilterFactory<TRequest, GamesFilterOperators> where TRequest : IFilteredRequest
	{

		public static IGamesFilterCreator FilterCreator { get; set; } = new GamesFilterCreator();

		public GamesFilterFactory(TRequest request)
			: base(request)
		{
		}

		protected override IFilterCreator<GamesFilterOperators> GetFilterCreator()
		{
			return FilterCreator;
		}
		
		public TRequest GameId(GamesFilterOperators @operator, int value) => CreateFilter("game_id", @operator, value);
		public TRequest DateStart(GamesFilterOperators @operator, DateTime value) => CreateFilter("date_start", @operator, value);
		public TRequest Season(GamesFilterOperators @operator, int value) => CreateFilter("season", @operator, value);
		public TRequest Week(GamesFilterOperators @operator, int value) => CreateFilter("week", @operator, value);
		public TRequest Temperature(GamesFilterOperators @operator, int value) => CreateFilter("temperature", @operator, value);
		public TRequest Attendance(GamesFilterOperators @operator, int value) => CreateFilter("attendance", @operator, value);
		public TRequest Team(GamesFilterOperators @operator, string value) => CreateFilter("team", @operator, value);
		public TRequest Team1(GamesFilterOperators @operator, string value) => CreateFilter("team_1", @operator, value);
		public TRequest Team2(GamesFilterOperators @operator, string value) => CreateFilter("team_2", @operator, value);
		public TRequest EventTypeId(GamesFilterOperators @operator, int value) => CreateFilter("event_type_id", @operator, value);
		public TRequest PlayByPlaySequence(GamesFilterOperators @operator, int value) => CreateFilter("pbp", @operator, value);
	}
}
