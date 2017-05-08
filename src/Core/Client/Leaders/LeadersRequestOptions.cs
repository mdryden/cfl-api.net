using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Leaders
{
	public class LeadersRequestOptions
	{
		public IEnumerable<LeadersFilter> Filters { get; set; } = new List<LeadersFilter>();
	}
}
