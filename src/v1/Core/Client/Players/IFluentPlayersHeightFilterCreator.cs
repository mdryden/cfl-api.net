namespace mdryden.cflapi.v1.Client.Players
{
	public interface IFluentPlayersHeightFilterCreator
	{
		//IAdditionalFluentPlayersRequestOptions FormatHeight(int feet, int inches);
		IAdditionalFluentPlayersRequestOptions EqualTo(int feet, int inches);
		IAdditionalFluentPlayersRequestOptions GreaterThan(int feet, int inches);
		IAdditionalFluentPlayersRequestOptions GreaterThanOrEqualTo(int feet, int inches);
		IAdditionalFluentPlayersRequestOptions In(params string[] formattedHeights);
		IAdditionalFluentPlayersRequestOptions LessThan(int feet, int inches);
		IAdditionalFluentPlayersRequestOptions LessThanOrEqualTo(int feet, int inches);
		IAdditionalFluentPlayersRequestOptions NotEqualTo(int feet, int inches);

	}
}
