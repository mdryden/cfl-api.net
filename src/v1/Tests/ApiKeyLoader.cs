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
					if (File.Exists(@".\cfl_api_key.txt"))
					{
						apiKey = File.ReadAllText(@".\cfl_api_key.txt");
					}

					if (string.IsNullOrEmpty(apiKey))
					{
						throw new Exception("Unable to load API key.  See app.config for instructions");
					}
				}
			}

			return apiKey;
		}
	}
}
