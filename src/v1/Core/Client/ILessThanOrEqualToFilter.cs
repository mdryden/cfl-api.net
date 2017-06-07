using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface ILessThanOrEqualToFilter
	{
		string CreateLessThanOrEqualTo<TValue>(string filterProperty, TValue value);
	}
	public interface IFluentLessThanOrEqualToFilter<TValue, TReturn>
	{
		TReturn LessThanOrEqualTo(TValue value);
	}
}
