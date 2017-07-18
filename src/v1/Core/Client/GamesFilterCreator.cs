using System;

namespace mdryden.cflapi.v1.Client
{
	public class GamesFilterCreator : FilterCreator<GamesFilterOperators>, IGamesFilterCreator
	{
		protected override string GetOperatorString(GamesFilterOperators @operator)
		{
			switch (@operator)
			{
				case GamesFilterOperators.EqualTo:
					return "eq";

				case GamesFilterOperators.GreaterThan:
					return "gt";

				case GamesFilterOperators.GreaterThanOrEqualTo:
					return "ge";

				case GamesFilterOperators.LessThan:
					return "lt";

				case GamesFilterOperators.LessThanOrEqualTo:
					return "le";

				case GamesFilterOperators.NotEqualTo:
					return "ne";

				case GamesFilterOperators.In:
					return "in";

				default:
					throw new NotSupportedException($"Unknown FilterOperators value '{@operator}'.");
			}
		}
	}
}
