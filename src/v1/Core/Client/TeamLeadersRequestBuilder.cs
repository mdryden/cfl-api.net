﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public class TeamLeadersRequestBuilder<TRequestBuilder, TResponse> : RequestBuilder<IList<TResponse>>, ITeamLeadersRequestBuilder<TRequestBuilder, TResponse>
		where TRequestBuilder : class, IFilteredRequest
	{

		public static ITeamLeadersFilterFactoryFactory FilterFactoryFactory { get; set; } = new TeamLeadersFilterFactoryFactory();

		private string leaderType;
		private int season;

		public TeamLeadersRequestBuilder(string leaderType, int season)
		{
			this.leaderType = leaderType;
			this.season = season;
		}


		public TRequestBuilder Season(int season)
		{
			this.season = season;
			return this as TRequestBuilder;
		}

		public TRequestBuilder WithExtendedData()
		{
			Includes.Add("extended_data");
			return this as TRequestBuilder;
		}
		
		protected override string GetPath()
		{
			var path = $"/v1/team_leaders/{season}/category/{leaderType}";
			return path;
		}
		
		public void AddFilter(string filter) => Filters.Add(filter);

		public ITeamLeadersFilterFactory<TRequestBuilder> WithFilter() => FilterFactoryFactory.GetFilterFactory(this as TRequestBuilder);
	}
}
