using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.TeamLeaders
{
	public class TeamLeadersRequestOptions
	{
		public IEnumerable<string> Filters { get; set; } = new List<string>();
	}
}
