using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class SpecialTeamsLeadersRequestBuilder : LeadersRequestBuilder<ISpecialTeamsLeadersRequestBuilder, IList<SpecialTeams>>, ISpecialTeamsLeadersRequestBuilder
	{
		public SpecialTeamsLeadersRequestBuilder(int season)
			: base("special_teams", season)
		{

		}
	}
}
