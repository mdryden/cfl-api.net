//namespace mdryden.cflapi.v1.Client.Fluent
//{
//	public class FluentFilterFactory<TOptions, TFilterOperators> where TOptions : IFilteredRequest
//	{

//		private TOptions options;
//		IFilterCreator<TFilterOperators> creator;

//		public FluentFilterFactory(TOptions options, IFilterCreator<TFilterOperators> creator)
//		{
//			this.options = options;
//			this.creator = creator;
//		}

//		protected TOptions CreateFilter<TValue>(string filterProperty, TFilterOperators @operator, TValue value)
//		{
//			options.Filters.Add(creator.CreateFilter(filterProperty, @operator, value));
//			return options;
//		}

//	}
//}
