//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.Players
//{

//	public sealed class FluentPlayersHeightFilterCreator : FluentFilterCreator<string, PlayersRequestOptions, IAdditionalFluentPlayersRequestOptions>, 
//		IFluentPlayersHeightFilterCreator
//	{
//		private IPlayersHeightFilterCreator creator;

//		public FluentPlayersHeightFilterCreator(PlayersRequestOptions options, IPlayersHeightFilterCreator creator, string filterProperty)
//			: base(options, creator, filterProperty)
//		{
//			this.creator = creator;
//		}	



//		IAdditionalFluentPlayersRequestOptions IFluentPlayersHeightFilterCreator.EqualTo(int feet, int inches) => EqualTo(creator.FormatHeight(feet, inches));

//		IAdditionalFluentPlayersRequestOptions IFluentPlayersHeightFilterCreator.GreaterThan(int feet, int inches) => GreaterThan(creator.FormatHeight(feet, inches));

//		IAdditionalFluentPlayersRequestOptions IFluentPlayersHeightFilterCreator.GreaterThanOrEqualTo(int feet, int inches) => GreaterThanOrEqualTo(creator.FormatHeight(feet, inches));

//		IAdditionalFluentPlayersRequestOptions IFluentPlayersHeightFilterCreator.In(params string[] formattedHeights) => In(formattedHeights);

//		IAdditionalFluentPlayersRequestOptions IFluentPlayersHeightFilterCreator.LessThan(int feet, int inches) => LessThan(creator.FormatHeight(feet, inches));

//		IAdditionalFluentPlayersRequestOptions IFluentPlayersHeightFilterCreator.LessThanOrEqualTo(int feet, int inches) => LessThanOrEqualTo(creator.FormatHeight(feet, inches));

//		IAdditionalFluentPlayersRequestOptions IFluentPlayersHeightFilterCreator.NotEqualTo(int feet, int inches) => NotEqualTo(creator.FormatHeight(feet, inches));
//	}
//}
