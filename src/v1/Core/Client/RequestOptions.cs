using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class RequestOptions<TSort>
	{

		public IEnumerable<string> Filters { get; set; } = new List<string>();

		public IEnumerable<TSort> Sorts { get; set; } = new List<TSort>();
		
	}
}
