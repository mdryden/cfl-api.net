using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public sealed class PlayersSortFactory<TRequest> : SortFactory<TRequest>, IPlayersSortFactory<TRequest> where TRequest : ISortedRequest
	{
		public static ISortCreator SortCreator { get; set; } = new SortCreator();

		public PlayersSortFactory(TRequest request)
			: base(request)
		{
		}

		protected override ISortCreator GetSortCreator()
		{
			return SortCreator;
		}

		public TRequest CflCentralId(SortOrder order) => CreateSortAndReturnOptions("cfl_central_id", order);
		public TRequest FirstName(SortOrder order) => CreateSortAndReturnOptions("first_name", order);
		public TRequest MiddleName(SortOrder order) => CreateSortAndReturnOptions("middle_name", order);
		public TRequest LastName(SortOrder order) => CreateSortAndReturnOptions("last_name", order);
		public TRequest BirthDate(SortOrder order) => CreateSortAndReturnOptions("birth_date", order);
		public TRequest Height(SortOrder order) => CreateSortAndReturnOptions("height", order);
		public TRequest Weight(SortOrder order) => CreateSortAndReturnOptions("weight", order);
		public TRequest RookieYear(SortOrder order) => CreateSortAndReturnOptions("rookie_year", order);
		public TRequest ForeignPlayer(SortOrder order) => CreateSortAndReturnOptions("foreign_player", order);
		public TRequest SchoolId(SortOrder order) => CreateSortAndReturnOptions("school_id", order);
		public TRequest SchoolName(SortOrder order) => CreateSortAndReturnOptions("school_name", order);
		public TRequest PositionId(SortOrder order) => CreateSortAndReturnOptions("position_id", order);
		public TRequest PositionAbbreviation(SortOrder order) => CreateSortAndReturnOptions("position_abbreviation", order);
		public TRequest OffenceDefenceOrSpecial(SortOrder order) => CreateSortAndReturnOptions("offence_defence_or_special", order);

	}
}
