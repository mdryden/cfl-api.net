using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{
	public interface IFluentGamesRequestOptions :
		IFluentFilteredRequestOptions<FluentGamesFilterFactory>,
		IFluentSortedRequestOptions<FluentGamesSortFactory>,
		IGamesRequestOptions
	{
	}
}
