using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface IFilter
	{
		string GetFilter()
	}

	public interface IEqualToFilter<TValue>
	{
		//string CreateEqualTo<TValue>(string filterProperty, TValue value);
		 IFilter EqualTo(TValue value);
	}

	public interface IFluentEqualToFilter<TValue, TReturn>
	{
		TReturn EqualTo(TValue value);
	}
	
}
