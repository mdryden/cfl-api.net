//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client
//{
//	public sealed class Sort
//	{
//		private string sortProperty;
//		private SortOrder order;

//		public Sort(string sortProperty, SortOrder order)
//		{
//			this.order = order;
//		}

//		public string GetSortString()
//		{
//			return $"{SortOrderToString(order)}{sortProperty}";
//		}
		
//		private string SortOrderToString(SortOrder order)
//		{
//			switch (order)
//			{
//				case SortOrder.Ascending:
//					return "";

//				case SortOrder.Descending:
//					return "-";

//				default:
//					throw new NotSupportedException($"Unknown SortOrder value '{order}'.");
//			}
//		}
		
//	}

//	//public abstract class Sort<TSortType> : Sort
//	//{

//	//	private TSortType sortType;

//	//	public Sort(TSortType sortType, SortOrder order)
//	//		: base(order)
//	//	{
//	//		this.sortType = sortType;
//	//	}

//	//	protected override string GetSortTypesString()
//	//	{
//	//		return GetSortTypeString(sortType);
//	//	}

//	//	protected abstract string GetSortTypeString(TSortType sortType);
		

//	//}
//}
