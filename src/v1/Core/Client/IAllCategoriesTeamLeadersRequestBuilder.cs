using mdryden.cflapi.v1.Models.TeamLeaders;

namespace mdryden.cflapi.v1.Client
{

	public interface IAllCategoriesTeamLeadersRequestBuilder : ITeamLeadersRequestBuilder<IAllCategoriesTeamLeadersRequestBuilder, TeamAll>,
		IFilteredRequest
	{

	}
	public class AllCategoriesTeamLeadersRequestBuilder : TeamLeadersRequestBuilder<IAllCategoriesTeamLeadersRequestBuilder, TeamAll>, IAllCategoriesTeamLeadersRequestBuilder
	{
		public AllCategoriesTeamLeadersRequestBuilder(int season)
			: base("all", season)
		{

		}
	}
}
