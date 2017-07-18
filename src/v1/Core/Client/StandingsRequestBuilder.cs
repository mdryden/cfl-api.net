using mdryden.cflapi.v1.Models.Standings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class StandingsRequestBuilder : RequestBuilder<SeasonStandings>, IStandingsRequestBuilder
	{
		private int season;

		public StandingsRequestBuilder(int season)
		{
			this.season = season;
		}

		public IStandingsRequestBuilder Season(int season)
		{
			this.season = season;
			return this;
		}

		protected override string GetPath()
		{
			var path = $"/v1/standings/{season}";
			return path;
		}
	}
}
