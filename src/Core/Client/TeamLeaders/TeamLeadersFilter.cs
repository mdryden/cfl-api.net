using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.TeamLeaders
{
	public class TeamLeadersFilter : Filter<TeamLeadersFilterTypes>
	{
		public TeamLeadersFilter(TeamLeadersFilterTypes filter, FilterOperators @operator, string value) : base(filter, @operator, value)
		{
		}
		public TeamLeadersFilter(TeamLeadersFilterTypes filter, FilterOperators @operator, DateTime value) : base(filter, @operator, value)
		{
		}

		public static TeamLeadersFilter TeamId(FilterOperators @operator, int teamId)
		{
			return new TeamLeadersFilter(TeamLeadersFilterTypes.TeamId, @operator, teamId.ToString());
		}
		
		public static TeamLeadersFilter EndDate(FilterOperators @operator, DateTime endDate)
		{
			return new TeamLeadersFilter(TeamLeadersFilterTypes.EndDate, @operator, endDate);
		}

		protected override string GetFilterTypeString(TeamLeadersFilterTypes filter)
		{
			switch (filter)
			{
				case TeamLeadersFilterTypes.TeamId:
					return "team_id";

				case TeamLeadersFilterTypes.EndDate:
					return "end_date";

				case TeamLeadersFilterTypes.Week:
					return "week";

				default:
					throw new NotSupportedException($"Unknown LeaderFilterTypes value '{filter}'");
			}
		}
	}
}
