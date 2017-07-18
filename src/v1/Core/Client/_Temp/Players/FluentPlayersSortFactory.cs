using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Players
{
	public sealed class FluentPlayersSortFactory
	{

		private PlayersRequestOptions options;
		private ISortCreator creator;

		public FluentPlayersSortFactory(PlayersRequestOptions options, ISortCreator creator)
		{
			this.options = options;
			this.creator = creator;
		}

		public FluentPlayersSortCreator CflCentralId { get => new FluentPlayersSortCreator(options, creator, "cfl_central_id"); }
		public FluentPlayersSortCreator FirstName { get => new FluentPlayersSortCreator(options, creator, "first_name"); }
		public FluentPlayersSortCreator MiddleName { get => new FluentPlayersSortCreator(options, creator, "middle_name"); }
		public FluentPlayersSortCreator LastName { get => new FluentPlayersSortCreator(options, creator, "last_name"); }
		public FluentPlayersSortCreator BirthDate { get => new FluentPlayersSortCreator(options, creator, "birth_date"); }
		public FluentPlayersSortCreator Height { get => new FluentPlayersSortCreator(options, creator, "height"); }
		public FluentPlayersSortCreator Weight { get => new FluentPlayersSortCreator(options, creator, "weight"); }
		public FluentPlayersSortCreator RookieYear { get => new FluentPlayersSortCreator(options, creator, "rookie_year"); }
		public FluentPlayersSortCreator ForeignPlayer { get => new FluentPlayersSortCreator(options, creator, "foreign_player"); }
		public FluentPlayersSortCreator SchoolId { get => new FluentPlayersSortCreator(options, creator, "school_id"); }
		public FluentPlayersSortCreator SchoolName { get => new FluentPlayersSortCreator(options, creator, "school_name"); }
		public FluentPlayersSortCreator PositionId { get => new FluentPlayersSortCreator(options, creator, "position_id"); }
		public FluentPlayersSortCreator PositionAbbreviation { get => new FluentPlayersSortCreator(options, creator, "position_abbreviation"); }
		public FluentPlayersSortCreator OffenceDefenceOrSpecial { get => new FluentPlayersSortCreator(options, creator, "offence_defence_or_special"); }

	}
}
