//using mdryden.cflapi.v1.Client.Games;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.Fluent
//{


//	public class FluentGamesFilterCreator<TValue> : FluentFilterCreator<GamesRequestOptions, GameFilterOperators, TValue>
//	{
//		public FluentGamesFilterCreator(GamesRequestOptions options, IFilterCreator<GameFilterOperators> creator, string filterProperty)
//			: base(options, creator, filterProperty)
//		{

//		}


//		public GamesRequestOptions EqualTo(TValue value) => CreateFilterAndReturnOptions(GameFilterOperators.EqualTo, value);

//		public GamesRequestOptions GreaterThan(TValue value) => CreateFilterAndReturnOptions(GameFilterOperators.GreaterThan, value);

//		public GamesRequestOptions GreaterThanOrEqualTo(TValue value) => CreateFilterAndReturnOptions(GameFilterOperators.GreaterThanOrEqualTo, value);

//		public GamesRequestOptions In(params TValue[] values) => CreateFilterAndReturnOptions(GameFilterOperators.In, values);

//		public GamesRequestOptions LessThan(TValue value) => CreateFilterAndReturnOptions(GameFilterOperators.LessThan, value);

//		public GamesRequestOptions LessThanOrEqualTo(TValue value) => CreateFilterAndReturnOptions(GameFilterOperators.LessThanOrEqualTo, value);

//		public GamesRequestOptions NotEqualTo(TValue value) => CreateFilterAndReturnOptions(GameFilterOperators.NotEqualTo, value);

//	}
//}
