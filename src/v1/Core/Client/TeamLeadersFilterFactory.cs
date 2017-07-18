using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public class TeamLeadersFilterFactory<TRequestBuilder> : FilterFactory<TRequestBuilder, TeamLeadersFilterOperators>, ITeamLeadersFilterFactory<TRequestBuilder> where TRequestBuilder : IFilteredRequest
	{
		public static IFilterCreator<TeamLeadersFilterOperators> FilterCreator { get; set; }

		public TeamLeadersFilterFactory(TRequestBuilder request)
			: base(request)
		{

		}

		protected override IFilterCreator<TeamLeadersFilterOperators> GetFilterCreator()
		{
			return FilterCreator;
		}

		public TRequestBuilder TeamId(TeamLeadersFilterOperators @operator, int value) => CreateFilter("team_id", @operator, value);
		public TRequestBuilder EndDate(TeamLeadersFilterOperators @operator, DateTime value) => CreateFilter("end_date", @operator, value);
		public TRequestBuilder Week(TeamLeadersFilterOperators @operator, int value) => CreateFilter("week", @operator, value);

	}
	
}
