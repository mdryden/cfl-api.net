using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{
	public class GameSort : Sort<GameSortTypes>
	{
		public GameSort(GameSortTypes sortType, SortOrder order)
			: base(sortType, order)
		{

		}

		protected override string GetSortTypeString(GameSortTypes sortType)
		{
			switch (sortType)
			{
				case GameSortTypes.DateStart:
					return "date_start";

				case GameSortTypes.Season:
					return "season";

				case GameSortTypes.Week:
					return "week";

				case GameSortTypes.Temperature:
					return "temperature";

				case GameSortTypes.Attendance:
					return "attendance";

				case GameSortTypes.Team1:
					return "team_1";

				case GameSortTypes.Team2:
					return "team_2";

				default:
					throw new NotSupportedException($"Unknown GameSortType value '{sortType}");
			}
		}
	}
}
