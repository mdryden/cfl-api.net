using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface ILessThanOrEqualToFilter<TValue>
	{
		string LessThanOrEqualTo(TValue value);
	}
}
