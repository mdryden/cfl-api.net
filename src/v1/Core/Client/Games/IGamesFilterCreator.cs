using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{
	public interface IGamesFilterCreator<T> :
		//IFilterCreator,
		IEqualToFilter<T>
		//INotEqualToFilter,
		//IGreaterThanFilter,
		//ILessThanFilter,
		//IGreaterThanOrEqualToFilter,
		//ILessThanOrEqualToFilter,
		//IInFilter
	{
	}
}
