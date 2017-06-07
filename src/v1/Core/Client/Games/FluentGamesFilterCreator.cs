//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.Games
//{

//	public sealed class FluentGamesFilterCreator<TValue> : FluentFilterCreator<TValue, IGamesRequestOptions, IAdditionalFluentGamesRequestOptions>,
//		IFluentFilterCreator<TValue>,
//		IFluentGamesFilterCreator<TValue>
//	{
//		public FluentGamesFilterCreator(IGamesRequestOptions options, IGamesFilterCreator creator, string filterProperty)
//			: base(options, creator, filterProperty)
//		{

//		}

//		IAdditionalFluentGamesRequestOptions IFluentEqualToFilter<TValue, IAdditionalFluentGamesRequestOptions>.EqualTo(TValue value) => EqualTo(value);

//		IAdditionalFluentGamesRequestOptions IFluentGreaterThanFilter<TValue, IAdditionalFluentGamesRequestOptions>.GreaterThan(TValue value) => GreaterThan(value);

//		IAdditionalFluentGamesRequestOptions IFluentGreaterThanOrEqualToFilter<TValue, IAdditionalFluentGamesRequestOptions>.GreaterThanOrEqualTo(TValue value) => GreaterThanOrEqualTo(value);

//		IAdditionalFluentGamesRequestOptions IFluentInFilter<TValue, IAdditionalFluentGamesRequestOptions>.In(params TValue[] values) => In(values);

//		IAdditionalFluentGamesRequestOptions IFluentLessThanFilter<TValue, IAdditionalFluentGamesRequestOptions>.LessThan(TValue value) => LessThan(value);

//		IAdditionalFluentGamesRequestOptions IFluentLessThanOrEqualToFilter<TValue, IAdditionalFluentGamesRequestOptions>.LessThanOrEqualTo(TValue value) => LessThanOrEqualTo(value);

//		IAdditionalFluentGamesRequestOptions IFluentNotEqualToFilter<TValue, IAdditionalFluentGamesRequestOptions>.NotEqualTo(TValue value) => NotEqualTo(value);
//	}
//}
