using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{

	public sealed class FluentGamesSortCreator : FluentSortCreator<GamesRequestOptions, IAdditionalFluentGamesRequestOptions>,
		IFluentGamesSortCreator
	{
		public FluentGamesSortCreator(GamesRequestOptions options, ISortCreator creator, string sortType)
			: base(options, creator, sortType)
		{
		}
	}
}
