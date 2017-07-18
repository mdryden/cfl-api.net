//namespace mdryden.cflapi.v1.Client.Fluent
//{
//	//public abstract class FluentSortCreator<TOptions, TAdditionalFluentRequestOptionsType> : IFluentSortCreator<TOptions, TAdditionalFluentRequestOptionsType>
//	//	where TOptions : ISortedRequest, TAdditionalFluentRequestOptionsType
//	public class FluentSortCreator<TOptions>
//	{

//		private TOptions options;
//		private ISortCreator creator;
//		private string sortType;

//		public FluentSortCreator(TOptions options, ISortCreator creator, string sortType)
//		{
//			this.options = options;
//			this.creator = creator;
//		}


//		public TOptions Ascending()
//		{
//			options.Sorts.Add(creator.CreateAscending(sortType));
//			return options;
//		}


//		public TOptions Descending()
//		{
//			options.AddSort(creator.CreateDescending(sortType));
//			return options;
//		}
//	}
//}
