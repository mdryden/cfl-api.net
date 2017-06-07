namespace mdryden.cflapi.v1.Client
{
	public abstract class FluentSortCreator<TOptions, TAdditionalFluentRequestOptionsType> : IFluentSortCreator<TOptions, TAdditionalFluentRequestOptionsType>
		where TOptions : ISortedRequestOptions, TAdditionalFluentRequestOptionsType
	{

		private TOptions options;
		private ISortCreator creator;
		private string sortType;

		public FluentSortCreator(TOptions options, ISortCreator creator, string sortType)
		{
			this.options = options;
			this.creator = creator;
		}


		public TAdditionalFluentRequestOptionsType Ascending()
		{
			options.AddSort(creator.CreateAscending(sortType));
			return options;
		}


		public TAdditionalFluentRequestOptionsType Descending()
		{
			options.AddSort(creator.CreateDescending(sortType));
			return options;
		}
	}
}
