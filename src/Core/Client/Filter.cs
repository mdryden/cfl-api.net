using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public abstract class Filter
	{

		private FilterOperators @operator;
		private string value;

		public Filter(FilterOperators @operator, string value)
		{
			this.@operator = @operator;
			this.value = value;
		}

		public string GetFilterString()
		{
			return FormatFilter(GetFilterTypeString(), GetOperatorString(@operator), value);
		}

		protected abstract string GetFilterTypeString();

		protected string GetOperatorString(FilterOperators @operator)
		{
			return FilterOperatorToString(@operator);
		}
		public static string FilterOperatorToString(FilterOperators @operator)
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

				default:
					throw new NotSupportedException($"Unknown FilterOperators value '{@operator}'.");
			}
		}

		public static string FormatFilter(string filter, string @operator, string value)
		{
			return $"filter[{filter}][{@operator}]={value}";
		}
	}

	public abstract class Filter<TFilterType> : Filter
	{

		private TFilterType filter;

		public Filter(TFilterType filter, FilterOperators @operator, string value)
			: base(@operator, value)
		{
			this.filter = filter;
		}

		protected override string GetFilterTypeString()
		{
			return GetFilterTypeString(filter);
		}

		protected abstract string GetFilterTypeString(TFilterType filter);
		

	}
}
