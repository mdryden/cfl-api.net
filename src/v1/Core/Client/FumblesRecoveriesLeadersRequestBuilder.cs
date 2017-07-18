using mdryden.cflapi.v1.Models.Leaders;
using System.Collections.Generic;

namespace mdryden.cflapi.v1.Client
{
	public class FumblesRecoveriesLeadersRequestBuilder : LeadersRequestBuilder<IFumblesRecoveriesLeadersRequestBuilder, IList<PlayerFumblesRecoveries>>, IFumblesRecoveriesLeadersRequestBuilder
	{
		public FumblesRecoveriesLeadersRequestBuilder(int season)
			: base("fumbles_recoveries", season)
		{

		}
	}
}
