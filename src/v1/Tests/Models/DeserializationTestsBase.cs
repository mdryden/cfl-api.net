using System;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using mdryden.cflapi.v1.Client;

namespace mdryden.cflapi.v1.Tests.Models
{
	public class DeserializationTestsBase
	{

		public DeserializationTestsBase()
		{
			var apiKey = ApiKeyLoader.GetApiKey();
			Endpoint.Setup(apiKey);
		}
	}
}
