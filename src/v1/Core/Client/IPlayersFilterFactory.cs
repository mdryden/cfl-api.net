using System;

namespace mdryden.cflapi.v1.Client
{
	public interface IPlayersFilterFactory<TRequest> where TRequest : IFilteredRequest
	{
		TRequest BirthDate(PlayersFilterOperators @operator, DateTime value);
		TRequest CflCentralId(PlayersFilterOperators @operator, params int[] value);
		TRequest FirstName(PlayersFilterOperators @operator, string value);
		TRequest ForeignPlayer(PlayersFilterOperators @operator, bool value);
		TRequest GameDate(PlayersFilterOperators @operator, DateTime value);
		TRequest GameId(PlayersFilterOperators @operator, int value);
		TRequest Height(PlayersFilterOperators @operator, int feet, int inches);
		TRequest LastName(PlayersFilterOperators @operator, string value);
		TRequest MiddleName(PlayersFilterOperators @operator, string value);
		TRequest OffenceDefenceOrSpecial(PlayersFilterOperators @operator, string value);
		TRequest PositionAbbreviation(PlayersFilterOperators @operator, string value);
		TRequest PositionId(PlayersFilterOperators @operator, int value);
		TRequest RookieYear(PlayersFilterOperators @operator, int value);
		TRequest SchoolId(PlayersFilterOperators @operator, int value);
		TRequest SchoolName(PlayersFilterOperators @operator, string value);
		TRequest Season(PlayersFilterOperators @operator, int value);
		TRequest Weight(PlayersFilterOperators @operator, int value);
	}

	public interface IPlayersInFilterFactory<TRequest> where TRequest : IFilteredRequest
	{
		//TRequest BirthDateIn(PlayersFilterOperators @operator, DateTime value);
		TRequest CflCentralIdIn(params int[] value);
		//TRequest FirstNameIn(PlayersFilterOperators @operator, string value);
		//TRequest ForeignPlayer(PlayersFilterOperators @operator, bool value);
		//TRequest GameDate(PlayersFilterOperators @operator, DateTime value);
		//TRequest GameId(PlayersFilterOperators @operator, int value);
		//TRequest Height(PlayersFilterOperators @operator, int feet, int inches);
		//TRequest LastName(PlayersFilterOperators @operator, string value);
		//TRequest MiddleName(PlayersFilterOperators @operator, string value);
		//TRequest OffenceDefenceOrSpecial(PlayersFilterOperators @operator, string value);
		//TRequest PositionAbbreviation(PlayersFilterOperators @operator, string value);
		//TRequest PositionId(PlayersFilterOperators @operator, int value);
		//TRequest RookieYear(PlayersFilterOperators @operator, int value);
		//TRequest SchoolId(PlayersFilterOperators @operator, int value);
		//TRequest SchoolName(PlayersFilterOperators @operator, string value);
		//TRequest Season(PlayersFilterOperators @operator, int value);
		//TRequest Weight(PlayersFilterOperators @operator, int value);
	}
}