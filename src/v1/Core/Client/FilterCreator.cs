using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public class Filter : IFilter
	{
		private string value;

		public Filter(string value)
		{
			this.value = value;
		}

		public string GetFilter()
		{
			return value;
		}
	}

	public class FilterCreator<TValue> : IFilterCreator<TValue>
	{
		private string filterProperty;

		public FilterCreator(string filterProperty)
		{
			this.filterProperty = filterProperty;
		}

		private string GetValueString(TValue value)
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

		protected IFilter CreateFilter(FilterOperators @operator, TValue value)
		{
			return CreateFilter(GetOperatorString(@operator), GetValueString(value));
		}

		protected IFilter CreateFilter(FilterOperators @operator, TValue[] values)
		{
			return CreateFilter(GetOperatorString(FilterOperators.In), GetValuesString(values));
		}

		protected string GetValuesString(TValue[] values)
		{
			return string.Join(",", values.Select(v => GetValueString(v)));
		}

		protected IFilter CreateFilter(string @operator, string value)
		{
			return new Filter($"filter[{filterProperty}][{@operator}]={value}");
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

		protected IFilter CreateEqualToFilter(TValue value)
		{
			return CreateFilter(GetOperatorString(FilterOperators.EqualTo), GetValueString(value));
		}

		protected IFilter CreateNotEqualToFilter(TValue value)
		{
			return CreateFilter(GetOperatorString(FilterOperators.NotEqualTo), GetValueString(value));
		}

		protected IFilter CreateGreaterThanFilter(TValue value)
		{
			return CreateFilter(GetOperatorString(FilterOperators.GreaterThan), GetValueString(value));
		}

		protected IFilter CreateLessThanFilter(TValue value)
		{
			return CreateFilter(GetOperatorString(FilterOperators.LessThan), GetValueString(value));
		}

		protected IFilter CreateGreaterThanOrEqualToFilter(TValue value)
		{
			return CreateFilter(GetOperatorString(FilterOperators.GreaterThanOrEqualTo), GetValueString(value));
		}

		protected IFilter CreateLessThanOrEqualToFilter(TValue value)
		{
			return CreateFilter(GetOperatorString(FilterOperators.LessThanOrEqualTo), GetValueString(value));
		}

		protected IFilter CreateInFilter(TValue[] values)
		{
			return CreateFilter(GetOperatorString(FilterOperators.In), GetValuesString(values));
		}
	}
}
