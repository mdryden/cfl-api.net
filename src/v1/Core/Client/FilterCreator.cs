using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public abstract class FilterCreator<TValue>
	{
		protected string FilterProperty { get; private set; }

		public FilterCreator(string filterProperty)
		{
			this.FilterProperty = filterProperty;
		}

		protected string GetValueString(DateTime value)
		{
			return value.ToString("yyyy-MM-dd");
		}

		protected string GetValueString<T>(T value)
		{
			return value.ToString();
		}

		protected string GetValuesString<T>(T[] values)
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

		protected string CreateEqualToFilter(TValue value)
		{
			return CreateFilter(FilterProperty, GetOperatorString(FilterOperators.EqualTo), GetValueString(value));
		}

		protected string CreateNotEqualToFilter(TValue value)
		{
			return CreateFilter(FilterProperty, GetOperatorString(FilterOperators.NotEqualTo), GetValueString(value));
		}

		protected string CreateGreaterThanFilter(TValue value)
		{
			return CreateFilter(FilterProperty, GetOperatorString(FilterOperators.GreaterThan), GetValueString(value));
		}

		protected string CreateLessThanFilter(TValue value)
		{
			return CreateFilter(FilterProperty, GetOperatorString(FilterOperators.LessThan), GetValueString(value));
		}

		protected string CreateGreaterThanOrEqualToFilter(TValue value)
		{
			return CreateFilter(FilterProperty, GetOperatorString(FilterOperators.GreaterThanOrEqualTo), GetValueString(value));
		}

		protected string CreateLessThanOrEqualToFilter(TValue value)
		{
			return CreateFilter(FilterProperty, GetOperatorString(FilterOperators.LessThanOrEqualTo), GetValueString(value));
		}

		protected string CreateInFilter(TValue[] values)
		{
			return CreateFilter(FilterProperty, GetOperatorString(FilterOperators.In), GetValuesString(values));
		}
	}
}
