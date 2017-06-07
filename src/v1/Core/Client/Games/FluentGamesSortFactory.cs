using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Games
{
	public class FluentGamesSortFactory
	{
		private GamesRequestOptions options;
		private ISortCreator creator;

		public FluentGamesSortFactory(GamesRequestOptions options, ISortCreator creator)
		{
			this.options = options;
			this.creator = creator;
		}

		public IFluentGamesSortCreator DateStart { get => new FluentGamesSortCreator(options, creator, "date_start"); }
		public IFluentGamesSortCreator Season { get => new FluentGamesSortCreator(options, creator, "season"); }
		public IFluentGamesSortCreator Week { get => new FluentGamesSortCreator(options, creator, "week"); }
		public IFluentGamesSortCreator Temperature { get => new FluentGamesSortCreator(options, creator, "temperature"); }
		public IFluentGamesSortCreator Attendance { get => new FluentGamesSortCreator(options, creator, "attendance"); }
		public IFluentGamesSortCreator Team1 { get => new FluentGamesSortCreator(options, creator, "team1"); }
		public IFluentGamesSortCreator Team2 { get => new FluentGamesSortCreator(options, creator, "team2"); }

	}
}
