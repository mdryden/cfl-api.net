using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Seasons
	{
		[JsonIgnore]
		public int PlayerId { get; set; }

		[JsonProperty("passing")]
		public IList<SeasonPassing> Passing { get; set; }

		[JsonProperty("receiving")]
		public IList<SeasonReceiving> Receiving { get; set; }

		[JsonProperty("rushing")]
		public IList<SeasonRushing> Rushing { get; set; }

		[JsonProperty("defence")]
		public IList<SeasonDefence> Defence { get; set; }

		[JsonProperty("field_goals")]
		public IList<SeasonFieldGoals> FieldGoals { get; set; }

		[JsonProperty("punts")]
		public IList<SeasonPunts> Punts { get; set; }

		/// <summary>
		/// Added in v1.17
		/// </summary>
		[JsonProperty("punt_returns")]
		public IList<SeasonPunts> PuntReturns { get; set; }

		/// <summary>
		/// Added in v1.17
		/// </summary>
		[JsonProperty("kickoff_returns")]
		public IList<SeasonPunts> KickoffReturns { get; set; }

		/// <summary>
		/// Added in v1.17
		/// </summary>
		[JsonProperty("missed_fg_returns")]
		public IList<SeasonPunts> MissedFieldGoalReturns { get; set; }






	}
}
