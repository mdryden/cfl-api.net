using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface IGreaterThanFilter
	{
		string CreateGreaterThan<TValue>(string filterProperty, TValue value);
	}

	public interface IFluentGreaterThanFilter<TValue, TReturn>
	{
		TReturn GreaterThan(TValue value);
	}

}
