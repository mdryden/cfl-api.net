using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class PlayersHeightFormatter : IPlayersHeightFormatter
	{		
		public string FormatHeight(int feet, int inches) => $"{feet}.{inches.ToString("00")}";
		
	}
}
