using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class TeamLeadersRequestFactory : ITeamLeadersRequestFactory
	{
		public static IFumblesForcedTeamLeadersRequestBuilder FumblesForcedTeamLeadersRequestBuilder { get; set; }
		public static IInterceptionsTeamLeadersRequestBuilder InterceptionsTeamLeadersRequestBuilder { get; set; }
		public static IPassesDefendedTeamLeadersRequestBuilder PassesDefendedTeamLeadersRequestBuilder { get; set; }
		public static IPassingTouchdownsTeamLeadersRequestBuilder PassingTouchdownsTeamLeadersRequestBuilder { get; set; }
		public static IPassingYardsTeamLeadersRequestBuilder PassingYardsTeamLeadersRequestBuilder { get; set; }
		public static IRushingTouchdownsTeamLeadersRequestBuilder RushingTouchdownsTeamLeadersRequestBuilder { get; set; }
		public static IRushingYardsTeamLeadersRequestBuilder RushingYardsTeamLeadersRequestBuilder { get; set; }
		public static ISacksTeamLeadersRequestBuilder SacksTeamLeadersRequestBuilder { get; set; }
		public static ITotalYardsTeamLeadersRequestBuilder TotalYardsTeamLeadersRequestBuilder { get; set; }
		public static IAllCategoriesTeamLeadersRequestBuilder AllCategoriesTeamLeadersRequestBuilder { get; set; }

		public IFumblesForcedTeamLeadersRequestBuilder FumblesForced(int season)
		{
			return FumblesForcedTeamLeadersRequestBuilder ?? new FumblesForcedTeamLeadersRequestBuilder(season);
		}

		public IInterceptionsTeamLeadersRequestBuilder Interceptions(int season)
		{
			return InterceptionsTeamLeadersRequestBuilder ?? new InterceptionsTeamLeadersRequestBuilder(season);
		}

		public IPassesDefendedTeamLeadersRequestBuilder PassesDefended(int season)
		{
			return PassesDefendedTeamLeadersRequestBuilder ?? new PassesDefendedTeamLeadersRequestBuilder(season);
		}

		public IPassingTouchdownsTeamLeadersRequestBuilder PassingTouchdowns(int season)
		{
			return PassingTouchdownsTeamLeadersRequestBuilder ?? new PassingTouchdownsTeamLeadersRequestBuilder(season);
		}

		public IPassingYardsTeamLeadersRequestBuilder PassingYards(int season)
		{
			return PassingYardsTeamLeadersRequestBuilder ?? new PassingYardsTeamLeadersRequestBuilder(season);
		}

		public IRushingTouchdownsTeamLeadersRequestBuilder RushingTouchdowns(int season)
		{
			return RushingTouchdownsTeamLeadersRequestBuilder ?? new RushingTouchdownsTeamLeadersRequestBuilder(season);
		}

		public IRushingYardsTeamLeadersRequestBuilder RushingYards(int season)
		{
			return RushingYardsTeamLeadersRequestBuilder ?? new RushingYardsTeamLeadersRequestBuilder(season);
		}

		public ISacksTeamLeadersRequestBuilder Sacks(int season)
		{
			return SacksTeamLeadersRequestBuilder ?? new SacksTeamLeadersRequestBuilder(season);
		}

		public ITotalYardsTeamLeadersRequestBuilder TotalYards(int season)
		{
			return TotalYardsTeamLeadersRequestBuilder ?? new TotalYardsTeamLeadersRequestBuilder(season);
		}

		public IAllCategoriesTeamLeadersRequestBuilder AllCategories(int season)
		{
			return AllCategoriesTeamLeadersRequestBuilder ?? new AllCategoriesTeamLeadersRequestBuilder(season);
		}

	}
}
