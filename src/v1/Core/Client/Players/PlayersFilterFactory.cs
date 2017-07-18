using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Players
{
	public class PlayersFilterFactory
	{
		public static PlayersFilterCreator<int> CflCentralId { get; private set; } = new Lazy<PlayersFilterCreator<int>>(() => new PlayersFilterCreator<int>("cfl_central_id")).Value;
		public static PlayersFilterCreator<string> FirstName { get; private set; } = new Lazy<PlayersFilterCreator<string>>(() => new PlayersFilterCreator<string>("first_name")).Value;
		public static PlayersFilterCreator<string> MiddleName { get; private set; } = new Lazy<PlayersFilterCreator<string>>(() => new PlayersFilterCreator<string>("middle_name")).Value;
		public static PlayersFilterCreator<string> LastName { get; private set; } = new Lazy<PlayersFilterCreator<string>>(() => new PlayersFilterCreator<string>("last_name")).Value;
		public static PlayersFilterCreator<DateTime> BirthDate { get; private set; } = new Lazy<PlayersFilterCreator<DateTime>>(() => new PlayersFilterCreator<DateTime>("birth_date")).Value;
		public static PlayersHeightFilterCreator Height { get; private set; } = new Lazy<PlayersHeightFilterCreator>(() => new PlayersHeightFilterCreator("height")).Value;
		public static PlayersFilterCreator<int> Weight { get; private set; } = new Lazy<PlayersFilterCreator<int>>(() => new PlayersFilterCreator<int>("weight")).Value;
		public static PlayersFilterCreator<int?> RookieYear { get; private set; } = new Lazy<PlayersFilterCreator<int?>>(() => new PlayersFilterCreator<int?>("rookie_year")).Value;
		public static PlayersFilterCreator<bool> ForeignPlayer { get; private set; } = new Lazy<PlayersFilterCreator<bool>>(() => new PlayersFilterCreator<bool>("foreign_player")).Value;
		public static PlayersFilterCreator<int> SchoolId { get; private set; } = new Lazy<PlayersFilterCreator<int>>(() => new PlayersFilterCreator<int>("school_id")).Value;
		public static PlayersFilterCreator<string> SchoolName { get; private set; } = new Lazy<PlayersFilterCreator<string>>(() => new PlayersFilterCreator<string>("school_name")).Value;
		public static PlayersFilterCreator<int> PositionId { get; private set; } = new Lazy<PlayersFilterCreator<int>>(() => new PlayersFilterCreator<int>("position_id")).Value;
		public static PlayersFilterCreator<string> PositionAbbreviation { get; private set; } = new Lazy<PlayersFilterCreator<string>>(() => new PlayersFilterCreator<string>("position_abbreviation")).Value;
		public static PlayersFilterCreator<string> OffenceDefenceOrSpecial { get; private set; } = new Lazy<PlayersFilterCreator<string>>(() => new PlayersFilterCreator<string>("offence_defence_or_special")).Value;
		public static PlayersFilterCreator<int> Season { get; private set; } = new Lazy<PlayersFilterCreator<int>>(() => new PlayersFilterCreator<int>("season")).Value;
		public static PlayersFilterCreator<int> GameId { get; private set; } = new Lazy<PlayersFilterCreator<int>>(() => new PlayersFilterCreator<int>("game_id")).Value;
		public static PlayersFilterCreator<DateTime> GameDate { get; private set; } = new Lazy<PlayersFilterCreator<DateTime>>(() => new PlayersFilterCreator<DateTime>("game_date")).Value;
	
	}
}
