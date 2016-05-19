using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models.Players;

namespace mdryden.cflapi.v1.EntityFramework

{
    public partial class EntityConfiguration
    {
		public void ConfigurePlayerEntities(DbModelBuilder builder, string tablePrefix = "Players_")
		{
			builder.Entity<Player>()
				.HasKey(p => p.CflCentralId)
				.ToTable($"{tablePrefix}Player");

			builder.Entity<GameByGame>()
				.HasKey(g => g.PlayerId)
				.ToTable($"{tablePrefix}GameByGame");

			builder.Entity<GameDefence>()
				.HasKey(i => new { i.PlayerId, i.GameId })
				.ToTable($"{tablePrefix}GameDefence");

			builder.Entity<GameFieldGoals>()
				.HasKey(i => new { i.PlayerId, i.GameId })
				.ToTable($"{tablePrefix}GameFieldGoals");

			builder.Entity<GamePassing>()
				.HasKey(i => new { i.PlayerId, i.GameId })
				.ToTable($"{tablePrefix}GamePassing");

			builder.Entity<GamePunts>()
				.HasKey(i => new { i.PlayerId, i.GameId })
				.ToTable($"{tablePrefix}GamePunts");

			builder.Entity<GameReceiving>()
				.HasKey(i => new { i.PlayerId, i.GameId })
				.ToTable($"{tablePrefix}GameReceiving");

			builder.Entity<GameRushing>()
				.HasKey(i => new { i.PlayerId, i.GameId })
				.ToTable($"{tablePrefix}GameRushing");

			builder.Entity<Seasons>()
				.HasKey(i => i.PlayerId)
				.ToTable($"{tablePrefix}Seasons");

			builder.Entity<SeasonDefence>()
				.HasKey(i => new { i.PlayerId, i.Season })
				.ToTable($"{tablePrefix}SeasonDefence");

			builder.Entity<SeasonFieldGoals>()
				.HasKey(i => new { i.PlayerId, i.Season })
				.ToTable($"{tablePrefix}SeasonFieldGoals");

			builder.Entity<SeasonPassing>()
				.HasKey(i => new { i.PlayerId, i.Season })
				.ToTable($"{tablePrefix}SeasonPassing");

			builder.Entity<SeasonPunts>()
				.HasKey(i => new { i.PlayerId, i.Season })
				.ToTable($"{tablePrefix}SeasonPunts");

			builder.Entity<SeasonReceiving>()
				.HasKey(i => new { i.PlayerId, i.Season })
				.ToTable($"{tablePrefix}SeasonReceiving");

			builder.Entity<SeasonRushing>()
				.HasKey(i => new { i.PlayerId, i.Season })
				.ToTable($"{tablePrefix}SeasonRushing");
		}

    }
}
