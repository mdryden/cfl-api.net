using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Client
{
	public class LeadersRequestFactory : ILeadersRequestFactory
	{
		public static IConvert1LeadersRequestBuilder Convert1LeadersRequestBuilder { get; set; }
		public static IConvert2LeadersRequestBuilder Convert2LeadersRequestBuilder { get; set; }
		public static IFieldGoalsLeadersRequestBuilder FieldGoalsLeadersRequestBuilder { get; set; }
		public static IFieldGoalMissedReturnYardsLeadersRequestBuilder FieldGoalMissedReturnYardsLeadersRequestBuilder { get; set; }
		public static IFumblesForcedLeadersRequestBuilder FumblesForcedLeadersRequestBuilder { get; set; }
		public static IFumblesRecoveriesLeadersRequestBuilder FumblesRecoveriesLeadersRequestBuilder { get; set; }
		public static IInterceptionsLeadersRequestBuilder InterceptionsLeadersRequestBuilder { get; set; }
		public static IKickoffYardsLeadersRequestBuilder KickoffYardsLeadersRequestBuilder { get; set; }
		public static IKicksBlockedLeadersRequestBuilder KicksBlockedLeadersRequestBuilder { get; set; }
		public static IKickoffReturnYardsLeadersRequestBuilder KickoffReturnYardsLeadersRequestBuilder { get; set; }
		public static IPassingTouchdownsLeadersRequestBuilder PassingTouchdownsLeadersRequestBuilder { get; set; }
		public static IPassingYardsLeadersRequestBuilder PassingYardsLeadersRequestBuilder { get; set; }
		public static IReceivingTouchdownsLeadersRequestBuilder ReceivingTouchdownsLeadersRequestBuilder { get; set; }
		public static IReceivingYardsLeadersRequestBuilder ReceivingYardsLeadersRequestBuilder { get; set; }
		public static IReceivingCaughtLeadersRequestBuilder ReceivingCaughtLeadersRequestBuilder { get; set; }
		public static IReceivingTargetedLeadersRequestBuilder ReceivingTargetedLeadersRequestBuilder { get; set; }
		public static IRushingTouchdownsLeadersRequestBuilder RushingTouchdownsLeadersRequestBuilder { get; set; }
		public static IRushingYardsLeadersRequestBuilder RushingYardsLeadersRequestBuilder { get; set; }
		public static ISacksLeadersRequestBuilder SacksLeadersRequestBuilder { get; set; }
		public static ITacklesDefensiveLeadersRequestBuilder TacklesDefensiveLeadersRequestBuilder { get; set; }
		public static ITacklesSpecialTeamsLeadersRequestBuilder TacklesSpecialTeamsLeadersRequestBuilder { get; set; }
		public static IOffenceLeadersRequestBuilder OffenceLeadersRequestBuilder { get; set; }
		public static IDefenceLeadersRequestBuilder DefenceLeadersRequestBuilder { get; set; }
		public static ISpecialTeamsLeadersRequestBuilder SpecialTeamsLeadersRequestBuilder { get; set; }

		public IConvert1LeadersRequestBuilder Convert1s(int season)
		{
			return Convert1LeadersRequestBuilder ?? new Convert1LeadersRequestBuilder(season);
		}

		public IConvert2LeadersRequestBuilder Convert2s(int season)
		{
			return Convert2LeadersRequestBuilder ?? new Convert2LeadersRequestBuilder(season);
		}

		public IDefenceLeadersRequestBuilder Defence(int season)
		{
			return DefenceLeadersRequestBuilder ?? new DefenceLeadersRequestBuilder(season);
		}

		public IFieldGoalMissedReturnYardsLeadersRequestBuilder FieldGoalMissedReturnYards(int season)
		{
			return FieldGoalMissedReturnYardsLeadersRequestBuilder ?? new FieldGoalMissedReturnYardsLeadersRequestBuilder(season);
		}

		public IFieldGoalsLeadersRequestBuilder FieldGoals(int season)
		{
			return FieldGoalsLeadersRequestBuilder ?? new FieldGoalsLeadersRequestBuilder(season);
		}

		public IFumblesForcedLeadersRequestBuilder FumblesForced(int season)
		{
			return FumblesForcedLeadersRequestBuilder ?? new FumblesForcedLeadersRequestBuilder(season);
		}

		public IFumblesRecoveriesLeadersRequestBuilder FumblesRecoveries(int season)
		{
			return FumblesRecoveriesLeadersRequestBuilder ?? new FumblesRecoveriesLeadersRequestBuilder(season);
		}

		public IInterceptionsLeadersRequestBuilder Interceptions(int season)
		{
			return InterceptionsLeadersRequestBuilder ?? new InterceptionsLeadersRequestBuilder(season);
		}

		public IKickoffReturnYardsLeadersRequestBuilder KickoffReturnYards(int season)
		{
			return KickoffReturnYardsLeadersRequestBuilder ?? new KickoffReturnYardsLeadersRequestBuilder(season);
		}

		public IKickoffYardsLeadersRequestBuilder KickoffYards(int season)
		{
			return KickoffYardsLeadersRequestBuilder ?? new KickoffYardsLeadersRequestBuilder(season);
		}

		public IKicksBlockedLeadersRequestBuilder KicksBlocked(int season)
		{
			return KicksBlockedLeadersRequestBuilder ?? new KicksBlockedLeadersRequestBuilder(season);
		}

		public IOffenceLeadersRequestBuilder Offence(int season)
		{
			return OffenceLeadersRequestBuilder ?? new OffenceLeadersRequestBuilder(season);
		}

		public IPassingTouchdownsLeadersRequestBuilder PassingTouchdowns(int season)
		{
			return PassingTouchdownsLeadersRequestBuilder ?? new PassingTouchdownsLeadersRequestBuilder(season);
		}

		public IPassingYardsLeadersRequestBuilder PassingYards(int season)
		{
			return PassingYardsLeadersRequestBuilder ?? new PassingYardsLeadersRequestBuilder(season);
		}

		public IReceivingCaughtLeadersRequestBuilder ReceivingCaught(int season)
		{
			return ReceivingCaughtLeadersRequestBuilder ?? new ReceivingCaughtLeadersRequestBuilder(season);
		}

		public IReceivingTargetedLeadersRequestBuilder ReceivingTargeted(int season)
		{
			return ReceivingTargetedLeadersRequestBuilder ?? new ReceivingTargetedLeadersRequestBuilder(season);
		}

		public IReceivingTouchdownsLeadersRequestBuilder ReceivingTouchdowns(int season)
		{
			return ReceivingTouchdownsLeadersRequestBuilder ?? new ReceivingTouchdownsLeadersRequestBuilder(season);
		}

		public IReceivingYardsLeadersRequestBuilder ReceivingYards(int season)
		{
			return ReceivingYardsLeadersRequestBuilder ?? new ReceivingYardsLeadersRequestBuilder(season);
		}

		public IRushingTouchdownsLeadersRequestBuilder RushingTouchdowns(int season)
		{
			return RushingTouchdownsLeadersRequestBuilder ?? new RushingTouchdownsLeadersRequestBuilder(season);
		}

		public IRushingYardsLeadersRequestBuilder RushingYards(int season)
		{
			return RushingYardsLeadersRequestBuilder ?? new RushingYardsLeadersRequestBuilder(season);
		}

		public ISacksLeadersRequestBuilder Sacks(int season)
		{
			return SacksLeadersRequestBuilder ?? new SacksLeadersRequestBuilder(season);
		}

		public ISpecialTeamsLeadersRequestBuilder SpecialTeams(int season)
		{
			return SpecialTeamsLeadersRequestBuilder ?? new SpecialTeamsLeadersRequestBuilder(season);
		}

		public ITacklesDefensiveLeadersRequestBuilder TacklesDefensive(int season)
		{
			return TacklesDefensiveLeadersRequestBuilder ?? new TacklesDefensiveLeadersRequestBuilder(season);
		}

		public ITacklesSpecialTeamsLeadersRequestBuilder TacklesSpecialTeams(int season)
		{
			return TacklesSpecialTeamsLeadersRequestBuilder ?? new TacklesSpecialTeamsLeadersRequestBuilder(season);
		}
	}
}
