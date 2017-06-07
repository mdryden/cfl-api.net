namespace mdryden.cflapi.v1.Client
{
	public interface IFilterCreator<TValue>
	{
		IFilter CreateEqualTo(TValue value);
		IFilter CreateGreaterThan(TValue value);
		IFilter CreateGreaterThanOrEqualTo(TValue value);
		IFilter CreateIn(params TValue[] values);
		IFilter CreateLessThan(TValue value);
		IFilter CreateLessThanOrEqualTo(TValue value);
		IFilter CreateNotEqualTo(TValue value);
	}
}