using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models.Games;

namespace mdryden.cflapi.v1.Client.Games
{
	class IdSetter
	{

		public void SetIds(IEnumerable<Game> games)
		{
			foreach (var game in games)
			{
				SetIds(game);
			}
		}
		public void SetIds(Game game)
		{
			if (game.Boxscore != null)
			{
				game.Boxscore.GameId = game.GameId;

				game.Boxscore.Teams.GameId = game.GameId;
				SetBoxscoreTeamIds(game.Boxscore.Teams.Team1, game.GameId);
				SetBoxscoreTeamIds(game.Boxscore.Teams.Team2, game.GameId);

			}
			
			game.Team1.GameId = game.GameId;
			game.Team2.GameId = game.GameId;
		}

		private void SetBoxscoreTeamIds(BoxscoreTeam team, int gameId)
		{
			team.GameId = gameId;

			if (team.Defence != null) team.Defence.GameId = gameId;			//team.FieldGoalReturns.GameId = gameId; // I assume this will be added, but this property is currently missing from api responses.

			if (team.Kicking != null) team.Kicking.GameId = gameId;
			if (team.KickReturns != null) team.KickReturns.GameId = gameId;
			if (team.Passing != null) team.Passing.GameId = gameId;
			if (team.Players != null) team.Players.GameId = gameId;
			if (team.PuntReturns != null) team.PuntReturns.GameId = gameId;
			if (team.Punts != null) team.Punts.GameId = gameId;
			if (team.Receiving != null) team.Receiving.GameId = gameId;
			if (team.Rushing != null) team.Rushing.GameId = gameId;

			SetBoxscorePlayerIds(team.Players, gameId, team.TeamId);
		}

		private void SetBoxscorePlayerIds(BoxscorePlayers players, int gameId, int teamId)
		{
			players.GameId = gameId;
			players.TeamId = teamId;

			SetCollectionIds(players.Defence, gameId);
			SetCollectionIds(players.FieldGoalReturns, gameId);
			SetCollectionIds(players.Kicking, gameId);
			SetCollectionIds(players.KickReturns, gameId);
			SetCollectionIds(players.Passing, gameId);
			SetCollectionIds(players.PuntReturns, gameId);
			SetCollectionIds(players.Punts, gameId);
			SetCollectionIds(players.Receiving, gameId);
			SetCollectionIds(players.Rushing, gameId);
		}

		protected void SetCollectionIds(IEnumerable<object> collection, int value)
		{
			if (collection != null && collection.Count() > 0)
			{
				var type = collection.First().GetType();
				var property = type.GetProperty("GameId");
				
				foreach (var item in collection)
				{
					property.SetValue(item, value);
				}
			}
		}
	}
}
