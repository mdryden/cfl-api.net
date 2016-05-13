using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class RequestOptions<TFilter, TSort>
	{

		public IEnumerable<TFilter> Filters { get; set; } = new List<TFilter>();

		public IEnumerable<TSort> Sorts { get; set; } = new List<TSort>();
		
	}
}
