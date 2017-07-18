//namespace mdryden.cflapi.v1.Client.Fluent
//{
//	public class FluentSortFactory<TOptions> where TOptions : ISortedRequest
//	{
//		private TOptions options;
//		private ISortCreator creator;

//		public FluentSortFactory(TOptions options, ISortCreator creator)
//		{
//			this.options = options;
//			this.creator = creator;
//		}

//		public TOptions CreateSortAndReturnOptions(string sortProperty, SortOrder order)
//		{
//			options.Sorts.Add(creator.Create(sortProperty, order));
//			return options;
//		}
//	}
//}
