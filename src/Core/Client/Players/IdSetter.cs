using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models.Players;

namespace mdryden.cflapi.v1.Client.Players
{
	class IdSetter
	{

		public void SetIds(Player player)
		{
			SetGameByplayerIds(player);
			SetSeasonIds(player);

		}

		public void SetIds(IEnumerable<Player> players)
		{
			foreach (var player in players)
			{
				SetIds(player);
			}
		}


		private void SetGameByplayerIds(Player player)
		{
			if (player.GameByGame != null)
			{
				player.GameByGame.PlayerId = player.CflCentralId;
				
				SetCollectionIds(player.GameByGame.Defence, player.CflCentralId);
				SetCollectionIds(player.GameByGame.FieldGoals, player.CflCentralId);
				SetCollectionIds(player.GameByGame.Passing, player.CflCentralId);
				SetCollectionIds(player.GameByGame.Punts, player.CflCentralId);
				SetCollectionIds(player.GameByGame.Receiving, player.CflCentralId);
				SetCollectionIds(player.GameByGame.Rushing, player.CflCentralId);
			}
		}

		private void SetSeasonIds(Player player)
		{
			if (player.Seasons != null)
			{
				player.Seasons.PlayerId = player.CflCentralId;

				SetCollectionIds(player.Seasons.Defence, player.CflCentralId);
				SetCollectionIds(player.Seasons.FieldGoals, player.CflCentralId);
				SetCollectionIds(player.Seasons.Passing, player.CflCentralId);
				SetCollectionIds(player.Seasons.Punts, player.CflCentralId);
				SetCollectionIds(player.Seasons.Receiving, player.CflCentralId);
				SetCollectionIds(player.Seasons.Rushing, player.CflCentralId);
			}
		}

		private void SetCollectionIds(IEnumerable<object> collection, int value)
		{
			if (collection != null && collection.Count() > 0)
			{
				var type = collection.First().GetType();
				var property = type.GetProperty("PlayerId");
				
				foreach (var item in collection)
				{
					property.SetValue(item, value);
				}
			}
		}



	}
}
