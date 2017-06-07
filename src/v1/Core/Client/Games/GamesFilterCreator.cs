namespace mdryden.cflapi.v1.Client.Games
{
	public class GamesFilterCreator<TValue> : FilterCreator<TValue>, IGamesFilterCreator
	{
		public TValue EqualTo(string filterProperty, TValue value) => CreateEqualToFilter(filterProperty, value);
		//public string CreateGreaterThan<TValue>(string filterProperty, TValue value) => CreateGreaterThanFilter(filterProperty, value);
		//public string CreateGreaterThanOrEqualTo<TValue>(string filterProperty, TValue value) => CreateGreaterThanOrEqualToFilter(filterProperty, value);
		//public string CreateIn<TValue>(string filterProperty, params TValue[] values) => CreateInFilter(filterProperty, values);
		//public string CreateLessThan<TValue>(string filterProperty, TValue value) => CreateLessThanFilter(filterProperty, value);
		//public string CreateLessThanOrEqualTo<TValue>(string filterProperty, TValue value) => CreateLessThanOrEqualToFilter(filterProperty, value);
		//public string CreateNotEqualTo<TValue>(string filterProperty, TValue value) => CreateNotEqualToFilter(filterProperty, value);
	}
}
