using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{
	public class GameFilter : Filter<GameFilterTypes>
	{

		private GameFilter(GameFilterTypes filter, FilterOperators @operator, string value)
			: base(filter, @operator, value)
		{

		}

		public static GameFilter DateStart(FilterOperators  @operator, DateTime dateStart)
		{
			var eastern = TimeZoneInfo.ConvertTimeFromUtc(dateStart, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
			var offset = eastern.IsDaylightSavingTime() ? "-04:00" : "-05:00";
			var value = eastern.ToString("yyyy-MM-ddTHH:mm:ss") + offset;
			return new GameFilter(GameFilterTypes.DateStart, @operator, value);
		}

		public static GameFilter Season(FilterOperators @operator, int season)
		{
			return new GameFilter(GameFilterTypes.Season, @operator, season.ToString());
		}

		public static GameFilter Week(FilterOperators @operator, int week)
		{
			return new GameFilter(GameFilterTypes.Week, @operator, week.ToString());
		}

		public static GameFilter Temperature(FilterOperators @operator, int temperature)
		{
			return new GameFilter(GameFilterTypes.Temperature, @operator, temperature.ToString());
		}

		public static GameFilter Attendance(FilterOperators @operator, int attendance)
		{
			return new GameFilter(GameFilterTypes.Attendance, @operator, attendance.ToString());
		}

		public static GameFilter Team1(FilterOperators @operator, string teamAbbreviation)
		{
			return new GameFilter(GameFilterTypes.Team1, @operator, teamAbbreviation);
		}

		public static GameFilter Team2(FilterOperators @operator, string teamAbbreviation)
		{
			return new GameFilter(GameFilterTypes.Team2, @operator, teamAbbreviation);
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
