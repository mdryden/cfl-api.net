using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Players
{

	public sealed class FluentPlayersFilterCreator<TValue> : FluentFilterCreator<TValue, PlayersRequestOptions, IAdditionalFluentPlayersRequestOptions>,
		IFluentPlayersFilterCreator<TValue>,
		IFluentPlayersHeightFilterCreator

	{
		public FluentPlayersFilterCreator(PlayersRequestOptions options, IPlayersFilterCreator creator, string filterProperty)
			: base(options, creator, filterProperty)
		{

		}

		IAdditionalFluentPlayersRequestOptions IFluentEqualToFilter<TValue, IAdditionalFluentPlayersRequestOptions>.EqualTo(TValue value) => EqualTo(value);

		IAdditionalFluentPlayersRequestOptions IFluentGreaterThanFilter<TValue, IAdditionalFluentPlayersRequestOptions>.GreaterThan(TValue value) => GreaterThan(value);

		IAdditionalFluentPlayersRequestOptions IFluentGreaterThanOrEqualToFilter<TValue, IAdditionalFluentPlayersRequestOptions>.GreaterThanOrEqualTo(TValue value) => GreaterThanOrEqualTo(value);

		IAdditionalFluentPlayersRequestOptions IFluentInFilter<TValue, IAdditionalFluentPlayersRequestOptions>.In(params TValue[] values) => In(values);

		IAdditionalFluentPlayersRequestOptions IFluentLessThanFilter<TValue, IAdditionalFluentPlayersRequestOptions>.LessThan(TValue value) => LessThan(value);

		IAdditionalFluentPlayersRequestOptions IFluentLessThanOrEqualToFilter<TValue, IAdditionalFluentPlayersRequestOptions>.LessThanOrEqualTo(TValue value) => LessThanOrEqualTo(value);

		IAdditionalFluentPlayersRequestOptions IFluentNotEqualToFilter<TValue, IAdditionalFluentPlayersRequestOptions>.NotEqualTo(TValue value) => NotEqualTo(value);

	}
}
