using System;
using mdryden.cflapi.v1.Models;
using mdryden.cflapi.v1.Models.Games;
using mdryden.cflapi.v1.Models.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using mdryden.cflapi.v1.Client.Standings;
using System.Configuration;
using mdryden.cflapi.v1.Client.Players;
using mdryden.cflapi.v1.Client.Games;
using mdryden.cflapi.v1.Client.Leaders;

namespace mdryden.cflapi.v1.Tests.Models
{
	public class DeserializationTestsBase
	{
		protected string GetApiKey()
		{
			return ConfigurationManager.AppSettings["apiKey"];
		}

		protected void TryDeserialize<T>(string response)
		{
			var settings = new JsonSerializerSettings
			{
				MissingMemberHandling = MissingMemberHandling.Error,
			};
			
			var result = JsonConvert.DeserializeObject<T>(response, settings);
		}
	}
}
