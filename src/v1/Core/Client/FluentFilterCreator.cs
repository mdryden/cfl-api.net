namespace mdryden.cflapi.v1.Client
{
	public class FluentFilterCreator<TValue, TOptions, TAdditionalFluentRequestOptionsType> : IFluentFilterCreator<TValue, TOptions, TAdditionalFluentRequestOptionsType>
		where TOptions : IFilteredRequestOptions, TAdditionalFluentRequestOptionsType
	{
		private TOptions options;
		private IFilterCreator creator;
		private string filterProperty;

		public FluentFilterCreator(TOptions options, IFilterCreator creator, string filterProperty)
		{
			this.options = options;
			this.creator = creator;
			this.filterProperty = filterProperty;
		}

		protected TAdditionalFluentRequestOptionsType EqualTo(TValue value)
		{
			options.AddFilter(creator.CreateFilter(filterProperty, FilterOperators.EqualTo, value));
			return options;
		}

		protected TAdditionalFluentRequestOptionsType NotEqualTo(TValue value)
		{
			options.AddFilter(creator.CreateFilter(filterProperty, FilterOperators.NotEqualTo, value));
			return options;
		}

		protected TAdditionalFluentRequestOptionsType GreaterThan(TValue value)
		{
			options.AddFilter(creator.CreateFilter(filterProperty, FilterOperators.GreaterThan, value));
			return options;
		}

		protected TAdditionalFluentRequestOptionsType LessThan(TValue value)
		{
			options.AddFilter(creator.CreateFilter(filterProperty, FilterOperators.LessThan, value));
			return options;
		}

		protected TAdditionalFluentRequestOptionsType GreaterThanOrEqualTo(TValue value)
		{
			options.AddFilter(creator.CreateFilter(filterProperty, FilterOperators.GreaterThanOrEqualTo, value));
			return options;
		}

		protected TAdditionalFluentRequestOptionsType LessThanOrEqualTo(TValue value)
		{
			options.AddFilter(creator.CreateFilter(filterProperty, FilterOperators.LessThanOrEqualTo value));
			return options;
		}

		protected TAdditionalFluentRequestOptionsType In(TValue[] values)
		{
			options.AddFilter(creator.CreateFilter(filterProperty, FilterOperators.In, values));
			return options;
		}

	}
}
