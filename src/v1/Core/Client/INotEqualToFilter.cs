using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface INotEqualToFilter
	{
		string CreateNotEqualTo<TValue>(string filterProperty, TValue value);
	}
	public interface IFluentNotEqualToFilter<TValue, TReturn>
	{
		TReturn NotEqualTo(TValue value);
	}
}
