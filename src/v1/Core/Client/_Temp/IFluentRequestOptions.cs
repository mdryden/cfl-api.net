//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.Fluent
//{
//	public interface IFluentRequestOptions<TOptions> : IRequestOptions where TOptions : IRequestOptions
//	{
//		TOptions Options { get; }
//	}

//	public interface IFiltered<TOptions, TFilterFactory> : IFluentRequestOptions<TOptions> where TOptions : IRequestOptions
//	{
//	}

//	public interface ISortable<TOptions, TSortFactory> : IFluentRequestOptions<TOptions> where TOptions : IRequestOptions
//	{
//	}

//	public interface ISortableWithFilters<TOptions, TSortFactory, TFilterFactory> : ISortable<TOptions, TSortFactory>, IFiltered<TOptions, TFilterFactory> where TOptions : IRequestOptions
//	{

//	}
//}
