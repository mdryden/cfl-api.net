using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface ISortedRequest
	{
		void AddSort(string sort);

	}
	public interface IFluentSorts<TSortFactory> : ISortedRequest
	{
		TSortFactory WithSort();
	}
}