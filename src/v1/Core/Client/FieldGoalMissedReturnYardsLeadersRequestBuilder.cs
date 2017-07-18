using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class FieldGoalMissedReturnYardsLeadersRequestBuilder : LeadersRequestBuilder<IFieldGoalMissedReturnYardsLeadersRequestBuilder, IList<PlayerFieldGoalMissedReturnYards>>, IFieldGoalMissedReturnYardsLeadersRequestBuilder
	{
		public FieldGoalMissedReturnYardsLeadersRequestBuilder(int season)
			: base("field_goal_missed_return_yards", season)
		{

		}
	}
}
