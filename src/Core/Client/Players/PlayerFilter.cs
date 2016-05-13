using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Players
{
	public class PlayerFilter : Filter<PlayerFilterTypes>
	{

		private PlayerFilter(PlayerFilterTypes filter, FilterOperators @operator, string value)
			: base(filter, @operator, value)
		{

		}

		public static PlayerFilter CflCentralId(FilterOperators @operator, int cflCentralId)
		{
			return new PlayerFilter(PlayerFilterTypes.CflCentralId, @operator, cflCentralId.ToString());
		}

		public static PlayerFilter FirstName(FilterOperators @operator, string firstName)
		{
			return new PlayerFilter(PlayerFilterTypes.FirstName, @operator, firstName);
		}

		public static PlayerFilter MiddleName(FilterOperators @operator, string middleName)
		{
			return new PlayerFilter(PlayerFilterTypes.MiddleName, @operator, middleName);
		}

		public static PlayerFilter LastName(FilterOperators @operator, string middleName)
		{
			return new PlayerFilter(PlayerFilterTypes.LastName, @operator, middleName);
		}

		public static PlayerFilter BirthDate(FilterOperators @operator, DateTime birthDate)
		{
			var value = birthDate.ToString("yyyy-MM-dd");
			return new PlayerFilter(PlayerFilterTypes.BirthDate, @operator, value);
		}

		public static PlayerFilter Height(FilterOperators @operator, int feet, int inches)
		{
			var value = $"{feet}.{inches.ToString("00")}";
			return new PlayerFilter(PlayerFilterTypes.Height, @operator, value);
		}

		public static PlayerFilter Weight(FilterOperators @operator, int weight)
		{
			return new PlayerFilter(PlayerFilterTypes.Weight, @operator, weight.ToString());
		}

		public static PlayerFilter RookieYear(FilterOperators @operator, int year)
		{
			return new PlayerFilter(PlayerFilterTypes.RookieYear, @operator, year.ToString());
		}

		public static PlayerFilter ForeignPlayer(FilterOperators @operator, bool foreignPlayer)
		{
			return new PlayerFilter(PlayerFilterTypes.ForeignPlayer, @operator, foreignPlayer.ToString().ToLower());
		}

		public static PlayerFilter SchoolId(FilterOperators @operator, int schoolId)
		{
			return new PlayerFilter(PlayerFilterTypes.SchoolId, @operator, schoolId.ToString());
		}

		public static PlayerFilter SchoolName(FilterOperators @operator, string schoolName)
		{
			return new PlayerFilter(PlayerFilterTypes.SchoolName, @operator, schoolName);
		}

		public static PlayerFilter PositionId(FilterOperators @operator, int positionId)
		{
			return new PlayerFilter(PlayerFilterTypes.PositionId, @operator, positionId.ToString());
		}

		public static PlayerFilter PositionAbbreviation(FilterOperators @operator, string abbreviation)
		{
			return new PlayerFilter(PlayerFilterTypes.PositionAbbreviation, @operator, abbreviation);
		}

		public static PlayerFilter OffenceDefenceOrSpecial(FilterOperators @operator, string offenceDefenceOrSpecial)
		{
			return new PlayerFilter(PlayerFilterTypes.OffenceDefenceOrSpecial, @operator, offenceDefenceOrSpecial);
		}

		protected override string GetFilterTypeString(PlayerFilterTypes filter)
		{
			return FilterTypeToString(filter);
		}

		public static string FilterTypeToString(PlayerFilterTypes filter)
		{
			switch (filter)
			{
				case PlayerFilterTypes.CflCentralId:
					return "cfl_central_id";

				case PlayerFilterTypes.FirstName:
					return "first_name";

				case PlayerFilterTypes.MiddleName:
					return "middle_name";

				case PlayerFilterTypes.LastName:
					return "last_name";

				case PlayerFilterTypes.BirthDate:
					return "birth_date";

				case PlayerFilterTypes.Height:
					return "height";

				case PlayerFilterTypes.Weight:
					return "weight";

				case PlayerFilterTypes.RookieYear:
					return "rookie_year";

				case PlayerFilterTypes.ForeignPlayer:
					return "foreign_player";

				case PlayerFilterTypes.SchoolId:
					return "school_id";

				case PlayerFilterTypes.SchoolName:
					return "school_name";

				case PlayerFilterTypes.PositionAbbreviation:
					return "position_abbreviation";

				case PlayerFilterTypes.PositionId:
					return "position_id";

				case PlayerFilterTypes.OffenceDefenceOrSpecial:
					return "offence_defence_or_special";

				default:
					throw new NotSupportedException($"Unknown PlayerFilterType value '{filter}'.");
			}
		}
	}
}
