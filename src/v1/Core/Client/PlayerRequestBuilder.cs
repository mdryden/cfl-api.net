using mdryden.cflapi.v1.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{

	public class PlayerRequestBuilder : RequestBuilder<Player, IList<Player>>, IPlayerRequestBuilder
	{
		private int cflCentralId;

		public PlayerRequestBuilder(int cflCentralId)
		{
			this.cflCentralId = cflCentralId;
		}

		public IPlayerRequestBuilder CflCentralId(int cflCentralId)
		{
			this.cflCentralId = cflCentralId;
			return this;
		}

		public IPlayerRequestBuilder WithSeasons()
		{
			Includes.Add("seasons");
			return this;
		}

		public IPlayerRequestBuilder WithGameByGame()
		{
			Includes.Add("game_by_game");
			return this;
		}

		public IPlayerRequestBuilder WithCurrentTeam()
		{
			Includes.Add("current_team");
			return this;
		}

		protected override string GetPath()
		{
			var path = $"/v1/players/{cflCentralId}";
			return path;
		}

		public override Player CleanResponse(IList<Player> apiResponse)
		{
			return apiResponse.FirstOrDefault();
		}
	}
}
