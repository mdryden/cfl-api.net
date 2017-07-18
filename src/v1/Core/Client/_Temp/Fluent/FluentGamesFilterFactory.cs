//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using mdryden.cflapi.v1.Client.Games;

//namespace mdryden.cflapi.v1.Client.Fluent
//{

//	public class FluentGamesFilterFactory : FluentFilterFactory<GamesRequestOptions, GameFilterOperators>
//	{
//		public FluentGamesFilterFactory(GamesRequestOptions options, IGamesFilterCreator creator)
//			: base(options, creator)
//		{
//		}
//		public GamesRequestOptions GameId(GameFilterOperators @operator, int value) => CreateFilter("game_id", @operator, value);
//		public GamesRequestOptions DateStart(GameFilterOperators @operator, DateTime value) => CreateFilter("date_start", @operator, value);
//		public GamesRequestOptions Season(GameFilterOperators @operator, int value) => CreateFilter("season", @operator, value);
//		public GamesRequestOptions Week(GameFilterOperators @operator, int value) => CreateFilter("week", @operator, value);
//		public GamesRequestOptions Temperature(GameFilterOperators @operator, int value) => CreateFilter("temperature", @operator, value);
//		public GamesRequestOptions Attendance(GameFilterOperators @operator, int value) => CreateFilter("attendance", @operator, value);
//		public GamesRequestOptions Team(GameFilterOperators @operator, string value) => CreateFilter("team", @operator, value);
//		public GamesRequestOptions Team1(GameFilterOperators @operator, string value) => CreateFilter("team_1", @operator, value);
//		public GamesRequestOptions Team2(GameFilterOperators @operator, string value) => CreateFilter("team_2", @operator, value);
//		public GamesRequestOptions EventTypeId(GameFilterOperators @operator, int value) => CreateFilter("event_type_id", @operator, value);
//		public GamesRequestOptions PlayByPlaySequence(GameFilterOperators @operator, int value) => CreateFilter("pbp", @operator, value);
//	}
//}
