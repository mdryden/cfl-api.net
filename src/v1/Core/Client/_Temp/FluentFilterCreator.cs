//namespace mdryden.cflapi.v1.Client.Fluent
//{
//	public class FluentFilterCreator<TOptions, TOperators, TValue> //: IFluentFilterCreator<TValue, TOptions, TAdditionalFluentRequestOptionsType>
//		where TOptions : IFilteredRequest
//	{
//		private TOptions options;
//		private IFilterCreator<TOperators> creator;
//		private string filterProperty;

//		public FluentFilterCreator(TOptions options, IFilterCreator<TOperators> creator, string filterProperty)
//		{
//			this.options = options;
//			this.creator = creator;
//			this.filterProperty = filterProperty;
//		}

//		protected TOptions CreateFilterAndReturnOptions(TOperators @operator, TValue value)
//		{
//			options.Filters.Add(creator.CreateFilter(filterProperty, @operator, value));
//			return options;
//		}
//		protected TOptions CreateFilterAndReturnOptions(TOperators @operator, TValue[] value)
//		{
//			options.Filters.Add(creator.CreateFilter(filterProperty, @operator, value));
//			return options;
//		}
//	}
//}
