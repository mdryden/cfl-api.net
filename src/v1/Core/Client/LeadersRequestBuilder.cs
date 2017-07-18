using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public class LeadersRequestBuilder<TRequestBuilder, TResponse> : RequestBuilder<TResponse>, ILeadersRequestBuilder<TRequestBuilder, TResponse>
		where TRequestBuilder : class, IFilteredRequest
	{

		public static ILeadersFilterFactoryFactory FilterFactoryFactory { get; set; } = new LeadersFilterFactoryFactory();

		private string leaderType;
		private int season;
		private TRequestBuilder requestBuilder;

		public LeadersRequestBuilder(string leaderType, int season)
		{
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
			var path = $"/v1/leaders/{season}/category/{leaderType}";
			return path;
		}
		
		public void AddFilter(string filter) => Filters.Add(filter);

		public ILeadersFilterFactory<TRequestBuilder> WithFilter() => FilterFactoryFactory.GetFilterFactory(this as TRequestBuilder);
	}
}
