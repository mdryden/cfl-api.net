//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using mdryden.cflapi.v1.Client.Games;
//using mdryden.cflapi.v1.Client.Players;
//using mdryden.cflapi.v1.Models;
//using mdryden.cflapi.v1.Models.Games;
//using mdryden.cflapi.v1.Models.Players;
//using Newtonsoft.Json;

//namespace mdryden.cflapi.v1.Client
//{
//	public interface IResponse<T>
//	{
//		string RequestUrl { get; }
//		string RawResponse { get; }

//		T GetResponse();
//	}

//	public class CollectionResponse<T> : IResponse<T[]>
//	{
//		public string RequestUrl { get; private set; }

//		public string RawResponse { get; private set; }

//		protected T[] GetResponse()
//		{
//			var response = GetResponse<DataArrayContainer<T>>(url);

//			return response != null ? response.Data : new T[] { };
//		}


//	}
//}
