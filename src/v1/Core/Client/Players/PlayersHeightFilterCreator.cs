using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Players
{
	public class PlayersHeightFilterCreator : 
		FilterCreator<string>
	{
		public PlayersHeightFilterCreator(string filterProperty)
			: base(filterProperty)
		{

		}
		
		private string FormatHeight(int feet, int inches)
		{
			return $"{feet}.{inches.ToString("00")}";
		}

		public string EqualTo(int feet, int inches)
		{
			return CreateEqualToFilter(FormatHeight(feet, inches));
		}

		public string NotEqualTo(int feet, int inches)
		{
			return CreateNotEqualToFilter(FormatHeight(feet, inches));
		}

		public string GreaterThan(int feet, int inches)
		{
			return CreateGreaterThanFilter(FormatHeight(feet, inches));
		}

		public string LessThan(int feet, int inches)
		{
			return CreateLessThanFilter(FormatHeight(feet, inches));
		}

		public string GreaterThanOrEqualTo(int feet, int inches)
		{
			return CreateGreaterThanOrEqualToFilter(FormatHeight(feet, inches));
		}

		public string LessThanOrEqualTo(int feet, int inches)
		{
			return CreateLessThanOrEqualToFilter(FormatHeight(feet, inches));
		}

		public string In(params string[] formattedHeights)
		{
			return CreateInFilter(formattedHeights);
		}
	}
}
