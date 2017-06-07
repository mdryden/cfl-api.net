using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface IHasFilters<TFilterFactory>
	{
		void AddFilter(string filter);
		IEnumerable<string> GetFilters();
		TFilterFactory FilterFactory { get; set; }
	}

	public interface IHasFluentFilters<TFilterFactory> : IHasFilters<TFilterFactory>
	{
	}

	//public class FilterCreator<TValue> : FilterCreator
	//{
	//	public string CreateEqualTo(string filterProperty, TValue value) => CreateEqualToFilter(filterProperty, value);
	//	public string CreateGreaterThan(string filterProperty, TValue value) => CreateGreaterThanFilter(filterProperty, value);
	//	public string CreateGreaterThanOrEqualTo(string filterProperty, TValue value) => CreateGreaterThanOrEqualToFilter(filterProperty, value);
	//	public string CreateIn(string filterProperty, params TValue[] values) => CreateInFilter(filterProperty, values);
	//	public string CreateLessThan(string filterProperty, TValue value) => CreateLessThanFilter(filterProperty, value);
	//	public string CreateLessThanOrEqualTo(string filterProperty, TValue value) => CreateLessThanOrEqualToFilter(filterProperty, value);
	//	public string CreateNotEqualTo(string filterProperty, TValue value) => CreateNotEqualToFilter(filterProperty, value);
	//}

	public interface IFilterFactory<TRequestOptions>
	{

	}

	//public class FluentRequestHelper<TRequestOptions>
	//{
	//	TRequestOptions RequestOptions { get; set; }
	//}

	public class FluentFilterFactory<TRequestOptions>
	{
		TRequestOptions RequestOptions { get; set; }

		public FluentFilterFactory(TRequestOptions requestOptions)
		{
			this.RequestOptions = requestOptions;
		}
	}

	public class FluentFilterCreator<TValue, TRequestOptions>
	{
		public IFilterCreator<TValue> FilterCreator { get; private set; }
		public TRequestOptions RequestOptions { get; private set; }

		public FluentFilterCreator(IFilterCreator<TValue> filterCreator, TRequestOptions requestOptions)
		{
			this.FilterCreator = filterCreator;
			this.requestOptions = requestOptions;
		}

	}
}
