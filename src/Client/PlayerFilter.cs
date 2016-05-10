using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class PlayerFilter : Filter<PlayerFilterTypes>
	{

		public PlayerFilter(PlayerFilterTypes filter, FilterOperators @operator, string value)
			: base(filter, @operator, value)
		{

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
					return "offence_defence_of_special";

				default:
					throw new NotSupportedException($"Unknown PlayerFilterType value '{filter}'.");
			}
		}
	}
}
