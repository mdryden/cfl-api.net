using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{

	public interface IGamesFilterFactory
	{
		IFilterCreator<int> GameId { get; }
	}

	public class GamesFilterFactory : IGamesFilterFactory
	{
		private IGamesFilterCreator creator;

		public GamesFilterFactory()
		{

		}

		public IFilterCreator<int> GameId { get => new FilterCreator<int>("game_id"); }
		public IFluentGamesFilterCreator<DateTime> DateStart { get => new FluentGamesFilterCreator<DateTime>(options, creator, "date_start"); }
		public IFluentGamesFilterCreator<int> Season { get => new FluentGamesFilterCreator<int>(options, creator, "season"); }
		public IFluentGamesFilterCreator<int> Week { get => new FluentGamesFilterCreator<int>(options, creator, "week"); }
		public IFluentGamesFilterCreator<int> Temperature { get => new FluentGamesFilterCreator<int>(options, creator, "temperature"); }
		public IFluentGamesFilterCreator<int> Attendance { get => new FluentGamesFilterCreator<int>(options, creator, "attendance"); }
		public IFluentGamesFilterCreator<string> Team { get => new FluentGamesFilterCreator<string>(options, creator, "team"); }
		public IFluentGamesFilterCreator<string> Team1 { get => new FluentGamesFilterCreator<string>(options, creator, "team_1"); }
		public IFluentGamesFilterCreator<string> Team2 { get => new FluentGamesFilterCreator<string>(options, creator, "team_2"); }
		public IFluentGamesFilterCreator<int> EventTypeId { get => new FluentGamesFilterCreator<int>(options, creator, "event_type_id"); }
		public IFluentGamesFilterCreator<int> PlayByPlaySequence { get => new FluentGamesFilterCreator<int>(options, creator, "pbp"); }
	}
}
