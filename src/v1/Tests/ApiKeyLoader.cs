using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Tests
{
	class ApiKeyLoader
	{
		private static object _lock = new object();
		private static string apiKey;

		public static string GetApiKey()
		{
			if (string.IsNullOrEmpty(apiKey))
			{
				lock (_lock)
				{
					apiKey = File.ReadAllText(@".\cfl_api_key.txt");

					if (string.IsNullOrEmpty(apiKey))
					{
						throw new Exception("Unable to load API key.  To run tests, create a file named 'cfl_api_key.txt' at the root which contains only your API key.");
					}
				}
			}

			return apiKey;
		}
	}
}
