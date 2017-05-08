using mdryden.cflapi.v1.Models.TeamLeaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client.TeamLeaders
{
	public class TeamLeadersClient : ClientBase
	{


		public TeamLeadersClient(string apiKey)
			: base(apiKey)
		{

		}
		
		private string BuildUrl(int season, int? topX, string leaderType, TeamLeadersRequestOptions options)
		{
			var path = $"/v1/team_leaders/{season}/category/{leaderType}";
			var url = GetUrl(path);

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

		private IList<T> GetLeadersList<T>(int season, int? topX, string leaderType, TeamLeadersRequestOptions options)
		{
			var url = BuildUrl(season, topX, leaderType, options);
			var leaders = GetCollectionResponse<T>(url);

			return leaders;
		}
		private T GetLeadersCategory<T>(int season, int? topX, string leaderType, TeamLeadersRequestOptions options)
		{
			var url = BuildUrl(season, topX, leaderType, options);
			var leaders = GetItemResponse<T>(url);

			return leaders;
		}

		public IList<TeamFumblesForced> GetFumblesForced(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamFumblesForced>(season, topX, "fumbles_forced", options);
		}

		public IList<TeamInterceptions> GetInterceptions(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamInterceptions>(season, topX, "interceptions", options);
		}

		public IList<TeamPassesDefended> GetPassesDefended(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamPassesDefended>(season, topX, "passes_defended", options);
		}

		public IList<TeamPassingTouchdowns> GetPassingTouchdowns(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamPassingTouchdowns>(season, topX, "passing_touchdowns", options);
		}

		public IList<TeamPassingYards> GetPassingYards(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamPassingYards>(season, topX, "passing_yards", options);
		}

		public IList<TeamRushingTouchdowns> GetRushingTouchdowns(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamRushingTouchdowns>(season, topX, "rushing_touchdowns", options);
		}

		public IList<TeamRushingYards> GetRushingYards(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamRushingYards>(season, topX, "rushing_yards", options);
		}

		public IList<TeamSacks> GetSacks(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamSacks>(season, topX, "sacks", options);
		}

		public IList<TeamTotalYards> GetTotalYards(int season, int? topX = null, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersList<TeamTotalYards>(season, topX, "total_yards", options);
		}
		
		public TeamAll GetAllCategories(int season, int topX = 9, TeamLeadersRequestOptions options = null)
		{
			return GetLeadersCategory<TeamAll>(season, topX, "all", options);
		}
		
	}
}
