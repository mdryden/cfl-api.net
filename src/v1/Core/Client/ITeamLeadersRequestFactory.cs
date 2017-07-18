namespace mdryden.cflapi.v1.Client
{
	public interface ITeamLeadersRequestFactory
	{
		IFumblesForcedTeamLeadersRequestBuilder FumblesForced(int season);
		IInterceptionsTeamLeadersRequestBuilder Interceptions(int season);
		IPassesDefendedTeamLeadersRequestBuilder PassesDefended(int season);
		IPassingTouchdownsTeamLeadersRequestBuilder PassingTouchdowns(int season);
		IPassingYardsTeamLeadersRequestBuilder PassingYards(int season);
		IRushingTouchdownsTeamLeadersRequestBuilder RushingTouchdowns(int season);
		IRushingYardsTeamLeadersRequestBuilder RushingYards(int season);
		ISacksTeamLeadersRequestBuilder Sacks(int season);
		ITotalYardsTeamLeadersRequestBuilder TotalYards(int season);
		IAllCategoriesTeamLeadersRequestBuilder AllCategories(int season);
	}
}
