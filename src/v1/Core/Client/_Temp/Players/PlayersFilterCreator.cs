//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.Players
//{
//	public class PlayersFilterCreator : FilterCreator, IPlayersFilterCreator, IPlayersHeightFilterCreator
//	{
//		public string CreateEqualTo<TValue>(string filterProperty, TValue value) => CreateEqualToFilter(filterProperty, value);
//		public string CreateGreaterThan<TValue>(string filterProperty, TValue value) => CreateGreaterThanFilter(filterProperty, value);
//		public string CreateGreaterThanOrEqualTo<TValue>(string filterProperty, TValue value) => CreateGreaterThanOrEqualToFilter(filterProperty, value);
//		public string CreateIn<TValue>(string filterProperty, params TValue[] values) => CreateInFilter(filterProperty, values);
//		public string CreateLessThan<TValue>(string filterProperty, TValue value) => CreateLessThanFilter(filterProperty, value);
//		public string CreateLessThanOrEqualTo<TValue>(string filterProperty, TValue value) => CreateLessThanOrEqualToFilter(filterProperty, value);
//		public string CreateNotEqualTo<TValue>(string filterProperty, TValue value) => CreateNotEqualToFilter(filterProperty, value);


//		const string heightFilterProperty = "height";
//		private string FormatHeight(int feet, int inches) => $"{feet}.{inches.ToString("00")}";
//		string IPlayersHeightFilterCreator.FormatHeight(int feet, int inches) => FormatHeight(feet, inches);
//		string IPlayersHeightFilterCreator.CreateEqualTo(int feet, int inches) => CreateEqualToFilter(heightFilterProperty, FormatHeight(feet, inches));
//		string IPlayersHeightFilterCreator.CreateGreaterThan(int feet, int inches) => CreateGreaterThanFilter(heightFilterProperty, FormatHeight(feet, inches));
//		string IPlayersHeightFilterCreator.CreateGreaterThanOrEqualTo(int feet, int inches) => CreateGreaterThanOrEqualToFilter(heightFilterProperty, FormatHeight(feet, inches));
//		string IPlayersHeightFilterCreator.CreateIn(params string[] formattedHeights) => CreateInFilter(heightFilterProperty, formattedHeights);
//		string IPlayersHeightFilterCreator.CreateLessThan(int feet, int inches) => CreateLessThanFilter(heightFilterProperty, FormatHeight(feet, inches));
//		string IPlayersHeightFilterCreator.CreateLessThanOrEqualTo(int feet, int inches) => CreateLessThanOrEqualToFilter(heightFilterProperty, FormatHeight(feet, inches));
//		string IPlayersHeightFilterCreator.CreateNotEqualTo(int feet, int inches) => CreateNotEqualToFilter(heightFilterProperty, FormatHeight(feet, inches));
//	}
//}
