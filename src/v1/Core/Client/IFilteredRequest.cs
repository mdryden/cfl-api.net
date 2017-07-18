using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public interface IFilteredRequest
	{
		void AddFilter(string filter);
		
	}
	public interface IFluentFilters<TFilterFactory> : IFilteredRequest
	{
		TFilterFactory WithFilter();
	}
}