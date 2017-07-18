using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Leaders
{
	public class LeadersFilterFactory
	{
		public static LeadersFilterCreator<int> TeamId { get; private set; } = new Lazy<LeadersFilterCreator<int>>(() => new LeadersFilterCreator<int>("team_id")).Value;
		public static LeadersFilterCreator<DateTime> EndDate { get; private set; } = new Lazy<LeadersFilterCreator<DateTime>>(() => new LeadersFilterCreator<DateTime>("end_date")).Value;

	}
}
