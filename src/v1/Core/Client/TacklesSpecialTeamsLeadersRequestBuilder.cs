using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class TacklesSpecialTeamsLeadersRequestBuilder : LeadersRequestBuilder<ITacklesSpecialTeamsLeadersRequestBuilder, IList<PlayerTacklesSpecialTeams>>, ITacklesSpecialTeamsLeadersRequestBuilder
	{
		public TacklesSpecialTeamsLeadersRequestBuilder(int season)
			: base("tackles_special_teams", season)
		{

		}
	}
}
