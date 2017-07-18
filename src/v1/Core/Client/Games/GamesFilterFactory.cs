using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{



	public class GamesFilterFactory
	{
		public static GamesFilterCreator<int> GameId { get; private set; } = new Lazy<GamesFilterCreator<int>>(() => new GamesFilterCreator<int>("game_id")).Value;
		public static GamesFilterCreator<DateTime> DateStart { get; private set; } = new Lazy<GamesFilterCreator<DateTime>>(() => new GamesFilterCreator<DateTime>("date_start")).Value;
		public static GamesFilterCreator<int> Season { get; private set; } = new Lazy<GamesFilterCreator<int>>(() => new GamesFilterCreator<int>("season")).Value;
		public static GamesFilterCreator<int> Week { get; private set; } = new Lazy<GamesFilterCreator<int>>(() => new GamesFilterCreator<int>("week")).Value;
		public static GamesFilterCreator<int> Temperature { get; private set; } = new Lazy<GamesFilterCreator<int>>(() => new GamesFilterCreator<int>("temperature")).Value;
		public static GamesFilterCreator<int> Attendance { get; private set; } = new Lazy<GamesFilterCreator<int>>(() => new GamesFilterCreator<int>("attendance")).Value;
		public static GamesFilterCreator<string> Team { get; private set; } = new Lazy<GamesFilterCreator<string>>(() => new GamesFilterCreator<string>("team")).Value;
		public static GamesFilterCreator<string> Team1 { get; private set; } = new Lazy<GamesFilterCreator<string>>(() => new GamesFilterCreator<string>("team_1")).Value;
		public static GamesFilterCreator<string> Team2 { get; private set; } = new Lazy<GamesFilterCreator<string>>(() => new GamesFilterCreator<string>("team_2")).Value;
		public static GamesFilterCreator<int> EventTypeId { get; private set; } = new Lazy<GamesFilterCreator<int>>(() => new GamesFilterCreator<int>("EventTypeId")).Value;
	}
}
