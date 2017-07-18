using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;
using System;

namespace mdryden.cflapi.v1.Client
{

	public class FieldGoalsLeadersRequestBuilder : LeadersRequestBuilder<IFieldGoalsLeadersRequestBuilder, IList<PlayerFieldGoals>>, IFieldGoalsLeadersRequestBuilder
	{
		public FieldGoalsLeadersRequestBuilder(int season)
			: base("field_goals", season)
		{

		}
	}
}
