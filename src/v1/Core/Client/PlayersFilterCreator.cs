using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class PlayersFilterCreator : FilterCreator<PlayersFilterOperators>, IPlayersFilterCreator
	{
		protected override string GetOperatorString(PlayersFilterOperators @operator)
		{
			switch (@operator)
			{
				case PlayersFilterOperators.EqualTo:
					return "eq";

				case PlayersFilterOperators.GreaterThan:
					return "gt";

				case PlayersFilterOperators.GreaterThanOrEqualTo:
					return "ge";

				case PlayersFilterOperators.LessThan:
					return "lt";

				case PlayersFilterOperators.LessThanOrEqualTo:
					return "le";

				case PlayersFilterOperators.NotEqualTo:
					return "ne";

				case PlayersFilterOperators.In:
					return "in";

				default:
					throw new NotSupportedException($"Unknown FilterOperators value '{@operator}'.");
			}
		}
	}
}
