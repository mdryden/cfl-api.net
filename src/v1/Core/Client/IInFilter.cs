using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface IInFilter
	{
		string CreateIn<TValue>(string filterProperty, params TValue[] values);
	}
	public interface IFluentInFilter<TValue, TReturn>
	{
		TReturn In(params TValue[] values);
	}
}
