using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Leaders
{
	public class LeadersFilter : Filter<LeadersFilterTypes>
	{
		public LeadersFilter(LeadersFilterTypes filter, FilterOperators @operator, string value) : base(filter, @operator, value)
		{
		}
		public LeadersFilter(LeadersFilterTypes filter, FilterOperators @operator, DateTime value) : base(filter, @operator, value)
		{
		}

		public static LeadersFilter TeamId(FilterOperators @operator, int teamId)
		{
			return new LeadersFilter(LeadersFilterTypes.TeamId, @operator, teamId.ToString());
		}
		
		public static LeadersFilter EndDate(FilterOperators @operator, DateTime endDate)
		{
			return new LeadersFilter(LeadersFilterTypes.EndDate, @operator, endDate);
		}

		protected override string GetFilterTypeString(LeadersFilterTypes filter)
		{
			switch (filter)
			{
				case LeadersFilterTypes.TeamId:
					return "team_id";

				case LeadersFilterTypes.EndDate:
					return "end_date";

				default:
					throw new NotSupportedException($"Unknown LeaderFilterTypes value '{filter}'");
			}
		}
	}
}
