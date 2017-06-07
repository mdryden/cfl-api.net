using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public interface ISortedRequestOptions
	{
		void AddSort(string sort);
		IEnumerable<string> GetSorts();
	}
}
//	public abstract class FilteredAndSortedRequestOptions<TFilterFactory, TSortFactory> :
//		//IFluentFilteredAndSortedRequestOptions<TFilterFactory, TSortFactory>,
//		//IAdditionalFluentFilteredAndSortedRequestOptions<TFilterFactory, TSortFactory>,
//		IFilteredRequestOptions,
//		ISortedRequestOptions,
//		IFluentFilteredAndSortedRequestOptions<TFilterFactory, TSortFactory>,
//		IAdditionalFluentFilteredAndSortedRequestOptions<TFilterFactory, TSortFactory>
//	{
//		private List<string> filters = new List<string>();
//		private List<string> sorts = new List<string>();

//		public IEnumerable<string> Filters { get { return filters; } }

//		public IEnumerable<string> Sorts { get { return sorts; } }

//		TFilterFactory IFluentFilteredRequestOptions<TFilterFactory>.WithFilter() => GetFilterFactory();
//		TSortFactory IFluentSortedRequestOptions<TSortFactory>.WithSort() => GetSortFactory();
//		TFilterFactory IAdditionalFluentFilteredRequestOptions<TFilterFactory>.AndFilter() => GetFilterFactory();
//		TSortFactory IAdditionalFluentSortedRequestOptions<TSortFactory>.AndSort() => GetSortFactory();

//		protected abstract TFilterFactory GetFilterFactory();
//		protected abstract TSortFactory GetSortFactory();

//		public void AddFilter(string filter)
//		{
//			filters.Add(filter);
//		}

//		public void AddSort(string sort)
//		{
//			sorts.Add(sort);
//		}

//	}

//}
