using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdryden.cflapi.v1.Models.Games;

namespace mdryden.cflapi.v1.EntityFramework
{
	public partial class EntityConfiguration
	{
		public void ConfigureGameEntities(DbModelBuilder builder, string tablePrefix = "Games_")
		{
			builder.Entity<Team>()
				.HasKey(t => new { t.GameId, t.TeamId })
				.ToTable($"{tablePrefix}Team");

			builder.Entity<Boxscore>()
				.HasKey(b => b.GameId)
				.ToTable($"{tablePrefix}BoxScore")
				.Property(b => b.GameId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			builder.Entity<BoxscoreTeams>()
				.HasKey(b => b.GameId)
				.ToTable($"{tablePrefix}BoxScoreTeams")
				.Property(b => b.GameId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			builder.Entity<BoxscoreTeam>()
				.HasKey(b => new { b.GameId, b.TeamId })
				.ToTable($"{tablePrefix}BoxScoreTeam");

			builder.Entity<BoxscorePlayers>()
				.HasKey(b => new { b.GameId, b.TeamId })
				.ToTable($"{tablePrefix}BoxscorePlayers");

			builder.Entity<PlayerDefence>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerDefence");

			builder.Entity<PlayerFieldGoalReturns>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerFieldGoalReturns");

			builder.Entity<PlayerKicking>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerKicking");

			builder.Entity<PlayerKickReturns>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerKickReturns");

			builder.Entity<PlayerPassing>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerPassing");

			builder.Entity<PlayerPuntReturns>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerPuntReturns");

			builder.Entity<PlayerPunts>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerPunts");

			builder.Entity<PlayerReceiving>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerReceiving");

			builder.Entity<PlayerRushing>()
				.HasKey(p => new { p.GameId, p.PlayerId })
				.ToTable($"{tablePrefix}PlayerRushing");

			builder.Entity<PlayPlayers>()
				.HasKey(p => p.PlayId)
				.ToTable($"{tablePrefix}PlayPlayers")
				.Property(p => p.PlayId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			builder.Entity<LineScore>()
				.HasKey(l => l.GameId)
				.ToTable($"{tablePrefix}LineScore")
				.Property(l => l.GameId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			builder.Entity<TeamDefence>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamDefence");

			builder.Entity<TeamFieldGoalReturns>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamFieldGoalReturns");

			builder.Entity<TeamKicking>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamKicking");

			builder.Entity<TeamKickReturns>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamKickReturns");

			builder.Entity<TeamPassing>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamPassing");

			builder.Entity<TeamPuntReturns>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamPuntReturns");

			builder.Entity<TeamPunts>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamPunts");

			builder.Entity<TeamReceiving>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamReceiving");

			builder.Entity<TeamRushing>()
				.HasKey(p => new { p.GameId, p.TeamId })
				.ToTable($"{tablePrefix}TeamRushing");

		}
	}
}
