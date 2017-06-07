using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{


	public class SortCreator : ISortCreator
	{

		public string CreateAscending(string sortType)
		{
			return $"{sortType}";
		}

		public string CreateDescending(string sortType)
		{
			return $"-{sortType}";
		}
	}
}
