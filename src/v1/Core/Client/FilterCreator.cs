using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public class FilterCreator : IFilterCreator
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

		public string CreateFilter<TValue>(string filterProperty, FilterOperators @operator, TValue value)
		{
			return CreateFilter(filterProperty, GetOperatorString(@operator), GetValueString(value));
		}

		public string CreateFilter<TValue>(string filterProperty, FilterOperators @operator, TValue[] values)
		{
			return CreateFilter(filterProperty, GetOperatorString(FilterOperators.In), GetValuesString(values));
		}

		protected string GetValuesString<TValue>(TValue[] values)
		{
			return string.Join(",", values.Select(v => GetValueString(v)));
		}

		protected string CreateFilter(string filterProperty, string @operator, string value)
		{
			return $"filter[{filterProperty}][{@operator}]={value}";
		}

		protected string GetOperatorString(FilterOperators @operator)
		{
			switch (@operator)
			{
				case FilterOperators.EqualTo:
					return "eq";

				case FilterOperators.GreaterThan:
					return "gt";

				case FilterOperators.GreaterThanOrEqualTo:
					return "ge";

				case FilterOperators.LessThan:
					return "lt";

				case FilterOperators.LessThanOrEqualTo:
					return "le";

				case FilterOperators.NotEqualTo:
					return "ne";

				case FilterOperators.In:
					return "in";

				default:
					throw new NotSupportedException($"Unknown FilterOperators value '{@operator}'.");
			}
		}

		protected string CreateEqualToFilter<TValue>(string filterProperty, TValue value)
		{
			return CreateFilter(filterProperty, GetOperatorString(FilterOperators.EqualTo), GetValueString(value));
		}

		protected string CreateNotEqualToFilter<TValue>(string filterProperty, TValue value)
		{
			return CreateFilter(filterProperty, GetOperatorString(FilterOperators.NotEqualTo), GetValueString(value));
		}

		protected string CreateGreaterThanFilter<TValue>(string filterProperty, TValue value)
		{
			return CreateFilter(filterProperty, GetOperatorString(FilterOperators.GreaterThan), GetValueString(value));
		}

		protected string CreateLessThanFilter<TValue>(string filterProperty, TValue value)
		{
			return CreateFilter(filterProperty, GetOperatorString(FilterOperators.LessThan), GetValueString(value));
		}

		protected string CreateGreaterThanOrEqualToFilter<TValue>(string filterProperty, TValue value)
		{
			return CreateFilter(filterProperty, GetOperatorString(FilterOperators.GreaterThanOrEqualTo), GetValueString(value));
		}

		protected string CreateLessThanOrEqualToFilter<TValue>(string filterProperty, TValue value)
		{
			return CreateFilter(filterProperty, GetOperatorString(FilterOperators.LessThanOrEqualTo), GetValueString(value));
		}

		protected string CreateInFilter<TValue>(string filterProperty, TValue[] values)
		{
			return CreateFilter(filterProperty, GetOperatorString(FilterOperators.In), GetValuesString(values));
		}
	}
}
