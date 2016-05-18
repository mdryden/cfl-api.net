using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class InvalidResponseException : Exception
	{
		public string RequestUrl { get; private set; }

		public InvalidResponseException(string message, string requestUrl)
			: base(message)
		{
			this.RequestUrl = requestUrl;
		}
	}
}
