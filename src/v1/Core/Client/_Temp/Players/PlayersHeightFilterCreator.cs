//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mdryden.cflapi.v1.Client.Players
//{
//	public class PlayersHeightFilterCreator : FilterCreator, IPlayersHeightFilterCreator
//	{

//		const string filterProperty = "height";

//		public string FormatHeight(int feet, int inches) => $"{feet}.{inches.ToString("00")}";
//		public string CreateEqualTo(int feet, int inches) => CreateEqualToFilter(filterProperty, FormatHeight(feet, inches));
//		public string CreateGreaterThan(int feet, int inches) => CreateGreaterThanFilter(filterProperty, FormatHeight(feet, inches));
//		public string CreateGreaterThanOrEqualTo(int feet, int inches) => CreateGreaterThanOrEqualToFilter("height", FormatHeight(feet, inches));
//		public string CreateIn(params string[] formattedHeights) => CreateInFilter(filterProperty, formattedHeights);
//		public string CreateLessThan(int feet, int inches) => CreateLessThanFilter(filterProperty, FormatHeight(feet, inches));
//		public string CreateLessThanOrEqualTo(int feet, int inches) => CreateLessThanOrEqualToFilter(filterProperty, FormatHeight(feet, inches));
//		public string CreateNotEqualTo(int feet, int inches) => CreateNotEqualToFilter(filterProperty, FormatHeight(feet, inches));
		
//	}
//}
