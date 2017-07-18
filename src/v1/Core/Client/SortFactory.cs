namespace mdryden.cflapi.v1.Client
{
	public abstract class SortFactory<TRequest> where TRequest : ISortedRequest
	{
		private TRequest request;

		public SortFactory(TRequest request)
		{
			this.request = request;
		}

		protected abstract ISortCreator GetSortCreator();

		public TRequest CreateSortAndReturnOptions(string sortProperty, SortOrder order)
		{
			request.AddSort(GetSortCreator().Create(sortProperty, order));
			return request;
		}
	}
}
