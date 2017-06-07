﻿namespace mdryden.cflapi.v1.Client.Players
{
	public interface IPlayersFilterCreator :
		IFilterCreator,
		IEqualToFilter,
		INotEqualToFilter,
		IGreaterThanFilter,
		ILessThanFilter,
		IGreaterThanOrEqualToFilter,
		ILessThanOrEqualToFilter,
		IInFilter
	{
		string FormatHeight(int feet, int inches);
		string CreateEqualTo(int feet, int inches);
		string CreateGreaterThan(int feet, int inches);
		string CreateGreaterThanOrEqualTo(int feet, int inches);
		string CreateIn(params string[] formattedHeights);
		string CreateLessThan(int feet, int inches);
		string CreateLessThanOrEqualTo(int feet, int inches);
		string CreateNotEqualTo(int feet, int inches);
	}
}