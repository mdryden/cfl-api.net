using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface ILessThanFilter<TValue>
	{
		string LessThan(TValue value);
	}
}
