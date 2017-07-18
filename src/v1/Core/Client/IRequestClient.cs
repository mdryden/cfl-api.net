using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public interface IRequestClient
	{
		string LastRequestUrl { get; }
		string LastResponse { get; }

		string GetRequestUrl(string path);
		Task<Response> InvokeAsync(string path);
		Response Invoke(string path);

	}
}