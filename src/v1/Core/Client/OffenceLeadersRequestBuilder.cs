using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class OffenceLeadersRequestBuilder : LeadersRequestBuilder<IOffenceLeadersRequestBuilder, IList<Offence>>, IOffenceLeadersRequestBuilder
	{
		public OffenceLeadersRequestBuilder(int season)
			: base("offence", season)
		{

		}
	}
}
