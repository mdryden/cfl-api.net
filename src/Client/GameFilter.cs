using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class GameFilter : Filter<GameFilterTypes>
	{

		public GameFilter(GameFilterTypes filter, FilterOperators @operator, string value)
			: base(filter, @operator, value)
		{

		}

		protected override string GetFilterTypeString(GameFilterTypes filter)
		{
			return FilterTypeToString(filter);
		}

		public static string FilterTypeToString(GameFilterTypes filter)
		{
			switch (filter)
			{
				case GameFilterTypes.Attendance:
					return "attendance";

				case GameFilterTypes.DateStart:
					return "date_start";

				case GameFilterTypes.Season:
					return "season";

				case GameFilterTypes.Team1:
					return "team_1";

				case GameFilterTypes.Team2:
					return "team_2";

				case GameFilterTypes.Temperature:
					return "temperature";

				case GameFilterTypes.Week:
					return "week";

				default:
					throw new NotSupportedException($"Unknown GameFilterTypes value '{filter}'");
			}
		}
	}
}
