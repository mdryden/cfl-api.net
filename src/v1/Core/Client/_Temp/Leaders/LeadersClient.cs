using mdryden.cflapi.v1.Models.Leaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.Leaders
{
	public class LeadersClient : ClientBase
	{

		public LeadersClient(string apiKey, string host = "http://api.cfl.ca")
			: base(apiKey, host)
		{

		}

		private string BuildUrl(int season, int? topX, string leaderType, LeadersRequestOptions options, bool includeExtendedData)
		{
			var path = $"/v1/leaders/{season}/category/{leaderType}";

			var url = GetUrl(path);

			if (includeExtendedData)
			{
				const string includesString = "include=extended_data";
				AppendParameter(ref url, includesString);
			}

			if (options != null)
			{
				AppendFilters(ref url, options.Filters);
			}

			if (topX != null)
			{
				AppendParameter(ref url, $"page[size]={topX}");
			}

			return url;
		}

		private IList<T> GetLeadersList<T>(int season, int? topX, string leaderType, LeadersRequestOptions options, bool includeExtendedData = false)
		{
			var url = BuildUrl(season, topX, leaderType, options, includeExtendedData);
			var leaders = GetCollectionResponse<T>(url);

			return leaders;
		}
		private T GetLeadersCategory<T>(int season, int? topX, string leaderType, LeadersRequestOptions options)
		{
			var url = BuildUrl(season, topX, leaderType, options, includeExtendedData: false);
			var leaders = GetItemResponse<T>(url);

			return leaders;
		}

		public IList<PlayerConverts1> GetConvert1(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerConverts1>(season, topX, "converts", options);
		}

		public IList<PlayerConverts2> GetConvert2(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerConverts2>(season, topX, "converts_2pt", options);
		}

		public IList<PlayerFieldGoals> GetFieldGoals(int season, int? topX = null, LeadersRequestOptions options = null, bool includeExtendedData = false)
		{
			return GetLeadersList<PlayerFieldGoals>(season, topX, "field_goals", options, includeExtendedData);
		}

		public IList<PlayerFieldGoalMissedReturnYards> GetFieldGoalMissedReturnYards(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerFieldGoalMissedReturnYards>(season, topX, "field_goal_missed_return_yards", options);
		}

		public IList<PlayerFumblesForced> GetFumblesForced(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerFumblesForced>(season, topX, "fumbles_forced", options);
		}

		public IList<PlayerFumblesRecoveries> GetFumblesRecoveries(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerFumblesRecoveries>(season, topX, "fumbles_recoveries", options);
		}

		public IList<Offence> GetInterceptions(int season, int? topX = null, LeadersRequestOptions options = null, bool includeExtendedData = false)
		{
			return GetLeadersList<Offence>(season, topX, "interceptions", options, includeExtendedData);
		}

		public IList<PlayerKicking> GetKicking(int season, int? topX = null, LeadersRequestOptions options = null, bool includeExtendedData = false)
		{
			return GetLeadersList<PlayerKicking>(season, topX, "kicking", options, includeExtendedData);
		}

		public IList<PlayerKickoffReturnYards> GetKickoffReturnYards(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerKickoffReturnYards>(season, topX, "kickoff_return_yards", options);
		}

		public IList<PlayerKickoffYards> GetKickoffYards(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerKickoffYards>(season, topX, "kickoff_yards", options);
		}

		public IList<PlayerKicksBlocked> GetKicksBlocked(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerKicksBlocked>(season, topX, "kicks_blocked", options);
		}

		public IList<PlayerPassingTouchdowns> GetPassingTouchdowns(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerPassingTouchdowns>(season, topX, "passing_touchdowns", options);
		}

		public IList<PlayerPassingYards> GetPassingYards(int season, int? topX = null, LeadersRequestOptions options = null, bool includeExtendedData = false)
		{
			return GetLeadersList<PlayerPassingYards>(season, topX, "passing_yards", options);
		}

		public IList<PlayerReceivingYards> GetReceivingTouchdowns(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerReceivingYards>(season, topX, "receiving_touchdowns", options);
		}

		public IList<PlayerReceivingYards> GetReceivingYards(int season, int? topX = null, LeadersRequestOptions options = null, bool includeExtendedData = false)
		{
			return GetLeadersList<PlayerReceivingYards>(season, topX, "receiving_yards", options, includeExtendedData);
		}

		public IList<PlayerReceivingCaught> GetReceivingCaught(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerReceivingCaught>(season, topX, "receiving_caught", options);
		}

		public IList<PlayerReceivingTargeted> GetReceivingTargeted(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerReceivingTargeted>(season, topX, "receiving_targeted", options);
		}

		public IList<PlayerReturns> GetReturns(int season, int? topX = null, LeadersRequestOptions options = null, bool includeExtendedData = true)
		{
			return GetLeadersList<PlayerReturns>(season, topX, "returns", options, includeExtendedData);
		}

		public IList<PlayerReturnYards> GetReturnYards(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerReturnYards>(season, topX, "return_yards", options);
		}

		public IList<PlayerRushingTouchdowns> GetRushingTouchdowns(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerRushingTouchdowns>(season, topX, "rushing_touchdowns", options);
		}

		public IList<PlayerRushingYards> GetRushingYards(int season, int? topX = null, LeadersRequestOptions options = null, bool includeExtendedData = false)
		{
			return GetLeadersList<PlayerRushingYards>(season, topX, "rushing_yards", options, includeExtendedData);
		}

		public IList<PlayerSacks> GetSacks(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerSacks>(season, topX, "sacks", options);
		}

		public IList<PlayerTacklesDefensive> GetTacklesDefensive(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerTacklesDefensive>(season, topX, "tackles_defensive", options);
		}

		public IList<PlayerTacklesSpecialTeams> GetTacklesSpecialTeams(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersList<PlayerTacklesSpecialTeams>(season, topX, "tackles_special_teams", options);
		}

		public Offence GetOffence(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersCategory<Offence>(season, topX, "offence", options);
		}

		public Defence GetDefence(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersCategory<Defence>(season, topX, "defence", options);
		}

		public SpecialTeams GetSpecialTeams(int season, int? topX = null, LeadersRequestOptions options = null)
		{
			return GetLeadersCategory<SpecialTeams>(season, topX, "special_teams", options);
		}
	}
}
