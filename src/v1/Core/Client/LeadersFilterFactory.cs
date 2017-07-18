using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class LeadersFilterFactory<TRequestBuilder> : FilterFactory<TRequestBuilder, LeadersFilterOperators>, ILeadersFilterFactory<TRequestBuilder> where TRequestBuilder : IFilteredRequest
	{
		public static IFilterCreator<LeadersFilterOperators> FilterCreator { get; set; }

		public LeadersFilterFactory(TRequestBuilder request)
			: base(request)
		{

		}

		protected override IFilterCreator<LeadersFilterOperators> GetFilterCreator()
		{
			return FilterCreator;
		}

		public TRequestBuilder TeamId(LeadersFilterOperators @operator, int value) => CreateFilter("team_id", @operator, value);
		public TRequestBuilder EndDate(LeadersFilterOperators @operator, DateTime value) => CreateFilter("end_date", @operator, value);

	}
}
