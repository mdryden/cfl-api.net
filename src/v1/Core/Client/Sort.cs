using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public abstract class Sort
	{

		private SortOrder order;

		public Sort(SortOrder order)
		{
			this.order = order;
		}

		public string GetSortString()
		{
			return FormatSort(GetSortTypesString(), GetOrderString(order));
		}

		protected abstract string GetSortTypesString();

		protected string GetOrderString(SortOrder order)
		{
			return SortOrderToString(order);
		}
		public static string SortOrderToString(SortOrder order)
		{
			switch (order)
			{
				case SortOrder.Ascending:
					return "";

				case SortOrder.Descending:
					return "-";

				default:
					throw new NotSupportedException($"Unknown SortOrder value '{order}'.");
			}
		}

		public static string FormatSort(string sortTypes, string order)
		{
			return $"{order}{sortTypes}";
		}
	}

	public abstract class Sort<TSortType> : Sort
	{

		private TSortType sortType;

		public Sort(TSortType sortType, SortOrder order)
			: base(order)
		{
			this.sortType = sortType;
		}

		protected override string GetSortTypesString()
		{
			return GetSortTypeString(sortType);
		}

		protected abstract string GetSortTypeString(TSortType sortType);
		

	}
}
