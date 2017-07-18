using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public abstract class FilterCreator<TOperators> : IFilterCreator<TOperators>
	{				
		protected string GetValueString<TValue>(TValue value)
		{
			if (value == null)
			{
				return string.Empty;
			}

			if (value is DateTime)
			{
				var date = value as DateTime?;
				return date.Value.ToString("yyyy-MM-dd");
			}

			return value.ToString();
		}

		public string CreateFilter<TValue>(string filterProperty, TOperators @operator, TValue value)
		{
			return FormatFilter(filterProperty, GetOperatorString(@operator), GetValueString(value));
		}

		public string CreateFilter<TValue>(string filterProperty, TOperators @operator, TValue[] values)
		{
			return FormatFilter(filterProperty, GetOperatorString(@operator), GetValuesString(values));
		}

		protected string GetValuesString<TValue>(TValue[] values)
		{
			return string.Join(",", values.Select(v => GetValueString(v)));
		}

		protected string FormatFilter(string filterProperty, string @operator, string value)
		{
			return $"filter[{filterProperty}][{@operator}]={value}";
		}

		protected abstract string GetOperatorString(TOperators @operator);
	}
}
