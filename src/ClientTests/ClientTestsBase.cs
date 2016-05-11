using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.ClientTests
{
	public abstract class ClientTestsBase
	{

		protected string GetApiKey()
		{
			return ConfigurationManager.AppSettings["apiKey"];
		}

	}
}
