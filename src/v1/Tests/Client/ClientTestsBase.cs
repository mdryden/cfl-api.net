using mdryden.cflapi.v1.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Tests.Client
{
	public abstract class ClientTestsBase
	{

		public ClientTestsBase()
		{
			Endpoint.Setup(GetApiKey());
		}

		protected string GetApiKey()
		{
			return ConfigurationManager.AppSettings["apiKey"];
		}

	}
}
