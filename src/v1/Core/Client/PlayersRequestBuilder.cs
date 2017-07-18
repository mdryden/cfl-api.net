using mdryden.cflapi.v1.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public class PlayersRequestBuilder : RequestBuilder<IList<Player>>, IPlayersRequestBuilder
	{
		public static IPlayersFilterFactory<IPlayersRequestBuilder> FilterFactory { get; set; }
		public static IPlayersSortFactory<IPlayersRequestBuilder> SortFactory { get; set; }

		public void AddFilter(string filter)
		{
			Filters.Add(filter);
		}

		public void AddSort(string sort)
		{
			Sorts.Add(sort);
		}

		public IPlayersRequestBuilder WithCurrentTeam()
		{
			Includes.Add("current_team");
			return this;
		}

		public IPlayersRequestBuilder PageNumber(int pageNumber)
		{
			SetPageNumber(pageNumber);
			return this;
		}

		public IPlayersRequestBuilder PageSize(int pageSize)
		{
			SetPageSize(pageSize);
			return this;
		}

		public IPlayersFilterFactory<IPlayersRequestBuilder> WithFilter() => FilterFactory ?? new PlayersFilterFactory<IPlayersRequestBuilder>(this);

		public IPlayersSortFactory<IPlayersRequestBuilder> WithSort() => SortFactory ?? new PlayersSortFactory<IPlayersRequestBuilder>(this); 

		protected override string GetPath()
		{
			const string path = "/v1/players";
			return path;
		}
	}
}
