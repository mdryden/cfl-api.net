using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Players
{
	public class PlayerSort : Sort<PlayerSortTypes>
	{
		public PlayerSort(PlayerSortTypes sortType, SortOrder order)
			: base(sortType, order)
		{

		}

		protected override string GetSortTypeString(PlayerSortTypes sortType)
		{
			switch (sortType)
			{
				case PlayerSortTypes.CflCentralId:
					return "cfl_central_id";

				case PlayerSortTypes.FirstName:
					return "first_name";

				case PlayerSortTypes.MiddleName:
					return "middle_name";

				case PlayerSortTypes.LastName:
					return "last_name";

				case PlayerSortTypes.BirthDate:
					return "birth_date";

				case PlayerSortTypes.Height:
					return "height";

				case PlayerSortTypes.Weight:
					return "weight";

				case PlayerSortTypes.RookieYear:
					return "rookie_year";

				case PlayerSortTypes.ForeignPlayer:
					return "foreign_player";

				case PlayerSortTypes.SchoolId:
					return "school_id";

				case PlayerSortTypes.SchoolName:
					return "school_name";

				case PlayerSortTypes.PositionId:
					return "position_id";

				case PlayerSortTypes.PositionAbbreviation:
					return "position_abbreviation";

				case PlayerSortTypes.OffenceDefenceOrSpecial:
					return "offence_defence_or_special";

				default:
					throw new NotSupportedException($"Unknown PlayerSortType value '{sortType}'");
			}
		}
	}
}
