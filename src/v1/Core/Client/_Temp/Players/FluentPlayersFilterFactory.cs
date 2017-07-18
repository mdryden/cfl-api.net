using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Players
{
	public sealed class FluentPlayersFilterFactory
	{

		private PlayersRequestOptions options;
		private PlayersFilterCreator creator;
		private PlayersHeightFilterCreator heightCreator;

		public FluentPlayersFilterFactory(PlayersRequestOptions options, PlayersFilterCreator creator, PlayersHeightFilterCreator heightCreator)
		{
			this.options = options;
			this.creator = creator;
			this.heightCreator = heightCreator;
		}

		public IFluentPlayersFilterCreator<int> CflCentralId { get => new FluentPlayersFilterCreator<int>(options, creator, "cfl_central_id"); }
		public IFluentPlayersFilterCreator<string> FirstName { get => new FluentPlayersFilterCreator<string>(options, creator, "first_name"); }
		public IFluentPlayersFilterCreator<string> MiddleName { get => new FluentPlayersFilterCreator<string>(options, creator, "middle_name"); }
		public IFluentPlayersFilterCreator<string> LastName { get => new FluentPlayersFilterCreator<string>(options, creator, "last_name"); }
		public IFluentPlayersFilterCreator<DateTime> BirthDate { get => new FluentPlayersFilterCreator<DateTime>(options, creator, "birth_date"); }
		public IFluentPlayersHeightFilterCreator Height { get => new FluentPlayersHeightFilterCreator(options, heightCreator, "height"); }
		public IFluentPlayersFilterCreator<int> Weight { get => new FluentPlayersFilterCreator<int>(options, creator, "weight"); }
		public IFluentPlayersFilterCreator<int?> RookieYear { get => new FluentPlayersFilterCreator<int?>(options, creator, "rookie_year"); }
		public IFluentPlayersFilterCreator<bool> ForeignPlayer { get => new FluentPlayersFilterCreator<bool>(options, creator, "foreign_player"); }
		public IFluentPlayersFilterCreator<int> SchoolId { get => new FluentPlayersFilterCreator<int>(options, creator, "school_id"); }
		public IFluentPlayersFilterCreator<string> SchoolName { get => new FluentPlayersFilterCreator<string>(options, creator, "school_name"); }
		public IFluentPlayersFilterCreator<int> PositionId { get => new FluentPlayersFilterCreator<int>(options, creator, "position_id"); }
		public IFluentPlayersFilterCreator<string> PositionAbbreviation { get => new FluentPlayersFilterCreator<string>(options, creator, "position_abbreviation"); }
		public IFluentPlayersFilterCreator<string> OffenceDefenceOrSpecial { get => new FluentPlayersFilterCreator<string>(options, creator, "offence_defence_or_special"); }
		public IFluentPlayersFilterCreator<int> Season { get => new FluentPlayersFilterCreator<int>(options, creator, "season"); }
		public IFluentPlayersFilterCreator<int> GameId { get => new FluentPlayersFilterCreator<int>(options, creator, "game_id"); }
		public IFluentPlayersFilterCreator<DateTime> GameDate { get => new FluentPlayersFilterCreator<DateTime>(options, creator, "game_date"); }

	}
}
