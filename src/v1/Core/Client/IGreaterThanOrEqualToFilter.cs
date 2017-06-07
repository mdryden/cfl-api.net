using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface IGreaterThanOrEqualToFilter
	{
		string CreateGreaterThanOrEqualTo<TValue>(string filterProperty, TValue value);
	}
	public interface IFluentGreaterThanOrEqualToFilter<TValue, TReturn>
	{
		TReturn GreaterThanOrEqualTo(TValue value);
	}
}
