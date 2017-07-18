namespace mdryden.cflapi.v1.Client
{
	public interface IPlayersSortFactory<TRequest> where TRequest : ISortedRequest
	{
		TRequest BirthDate(SortOrder order);
		TRequest CflCentralId(SortOrder order);
		TRequest FirstName(SortOrder order);
		TRequest ForeignPlayer(SortOrder order);
		TRequest Height(SortOrder order);
		TRequest LastName(SortOrder order);
		TRequest MiddleName(SortOrder order);
		TRequest OffenceDefenceOrSpecial(SortOrder order);
		TRequest PositionAbbreviation(SortOrder order);
		TRequest PositionId(SortOrder order);
		TRequest RookieYear(SortOrder order);
		TRequest SchoolId(SortOrder order);
		TRequest SchoolName(SortOrder order);
		TRequest Weight(SortOrder order);
	}
}