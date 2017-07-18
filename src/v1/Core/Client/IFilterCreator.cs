namespace mdryden.cflapi.v1.Client
{
	public interface IFilterCreator<TOperators>
	{
		string CreateFilter<TValue>(string filterProperty, TOperators @operator, TValue value);
		string CreateFilter<TValue>(string filterProperty, TOperators @operator, TValue[] values);
	}
}