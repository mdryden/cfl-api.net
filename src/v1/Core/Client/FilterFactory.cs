namespace mdryden.cflapi.v1.Client
{
	public abstract class FilterFactory<TRequest, TFilterOperators> where TRequest : IFilteredRequest
	{

		private TRequest request;

		public FilterFactory(TRequest request)
		{
			this.request = request;
		}

		protected abstract IFilterCreator<TFilterOperators> GetFilterCreator();

		protected TRequest CreateFilter<TValue>(string filterProperty, TFilterOperators @operator, TValue value)
		{
			request.AddFilter(GetFilterCreator().CreateFilter(filterProperty, @operator, value));
			return request;
		}
		protected TRequest CreateFilter<TValue>(string filterProperty, TFilterOperators @operator, TValue[] value)
		{
			request.AddFilter(GetFilterCreator().CreateFilter(filterProperty, @operator, value));
			return request;
		}

	}
}
