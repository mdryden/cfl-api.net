using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class PlayersFilterFactory<TRequest> : FilterFactory<TRequest, PlayersFilterOperators>, IPlayersFilterFactory<TRequest> where TRequest : IFilteredRequest
	{

		public static IPlayersHeightFormatter HeightFormatter { get; set; } = new PlayersHeightFormatter();
		public static IPlayersFilterCreator FilterCreator { get; set; } = new PlayersFilterCreator();

		public PlayersFilterFactory(TRequest request)
			: base(request)
		{
		}

		protected override IFilterCreator<PlayersFilterOperators> GetFilterCreator() => FilterCreator;

		public TRequest CflCentralId(PlayersFilterOperators @operator, params int[] value) => CreateFilter("cfl_central_id", @operator, value);
		public TRequest FirstName(PlayersFilterOperators @operator, string value) => CreateFilter("first_name", @operator, value);
		public TRequest MiddleName(PlayersFilterOperators @operator, string value) => CreateFilter("middle_name", @operator, value);
		public TRequest LastName(PlayersFilterOperators @operator, string value) => CreateFilter("last_name", @operator, value);
		public TRequest BirthDate(PlayersFilterOperators @operator, DateTime value) => CreateFilter("birth_date", @operator, value);
		public TRequest Height(PlayersFilterOperators @operator, int feet, int inches) => CreateFilter("height", @operator, HeightFormatter.FormatHeight(feet, inches));
		public TRequest Weight(PlayersFilterOperators @operator, int value) => CreateFilter("weight", @operator, value);
		public TRequest RookieYear(PlayersFilterOperators @operator, int value) => CreateFilter("rookie_year", @operator, value);
		public TRequest ForeignPlayer(PlayersFilterOperators @operator, bool value) => CreateFilter("foreign_player", @operator, value);
		public TRequest SchoolId(PlayersFilterOperators @operator, int value) => CreateFilter("school_id", @operator, value);
		public TRequest SchoolName(PlayersFilterOperators @operator, string value) => CreateFilter("school_name", @operator, value);
		public TRequest PositionId(PlayersFilterOperators @operator, int value) => CreateFilter("position_id", @operator, value);
		public TRequest PositionAbbreviation(PlayersFilterOperators @operator, string value) => CreateFilter("position_abbreviation", @operator, value);
		public TRequest OffenceDefenceOrSpecial(PlayersFilterOperators @operator, string value) => CreateFilter("offence_defence_or_special", @operator, value);
		public TRequest Season(PlayersFilterOperators @operator, int value) => CreateFilter("season", @operator, value);
		public TRequest GameId(PlayersFilterOperators @operator, int value) => CreateFilter("game_id", @operator, value);
		public TRequest GameDate(PlayersFilterOperators @operator, DateTime value) => CreateFilter("game_date", @operator, value);

	}
}
