namespace mdryden.cflapi.v1.Client
{
	public interface IPagedRequest<TRequest>
	{
		TRequest PageNumber(int pageNumber);
		TRequest PageSize(int pageSize);
	}
}
