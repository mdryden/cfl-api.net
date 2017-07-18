using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.TeamLeaders
{
	public class TeamLeadersFilterFactory
	{
		public static TeamLeadersFilterCreator<DateTime> EndDate { get; private set; } = new Lazy<TeamLeadersFilterCreator<DateTime>>(() => new TeamLeadersFilterCreator<DateTime>("end_date")).Value;
		public static TeamLeadersFilterCreator<int> TeamId { get; private set; } = new Lazy<TeamLeadersFilterCreator<int>>(() => new TeamLeadersFilterCreator<int>("team_id")).Value;
		public static TeamLeadersFilterCreator<int> Week { get; private set; } = new Lazy<TeamLeadersFilterCreator<int>>(() => new TeamLeadersFilterCreator<int>("week")).Value;
	}
}
