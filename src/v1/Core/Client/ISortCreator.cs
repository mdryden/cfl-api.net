namespace mdryden.cflapi.v1.Client
{
	public interface ISortCreator
	{
		string CreateAscending(string sortType);
		string CreateDescending(string sortType);
	}
}