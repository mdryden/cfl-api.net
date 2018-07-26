using mdryden.cflapi.v1.Models.Standings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	

	public class CrossoverStandingsRequestBuilder : RequestBuilder<CrossoverStandings>, ICrossoverStandingsRequestBuilder
	{
		private int season;

		public CrossoverStandingsRequestBuilder(int season)
		{
			this.season = season;
		}

		public ICrossoverStandingsRequestBuilder Season(int season)
		{
			this.season = season;
			return this;
		}

		protected override string GetPath()
		{
			var path = $"/v1/standings/crossover/{season}";
			return path;
		}
	}
}
