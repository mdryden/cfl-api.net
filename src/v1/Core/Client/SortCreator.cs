using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{


	public class SortCreator : ISortCreator
	{
		public string Create(string sortProperty, SortOrder order)
		{
			return $"{SortOrderToString(order)}{sortProperty}";
		}

		protected string SortOrderToString(SortOrder order)
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
	}
}
