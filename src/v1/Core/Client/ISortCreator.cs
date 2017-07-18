namespace mdryden.cflapi.v1.Client
{
	public interface ISortCreator
	{
		string Create(string sortProperty, SortOrder order);
	}
}