namespace mdryden.cflapi.v1.Client
{
	public interface ILeadersRequestFactory
	{
		IConvert1LeadersRequestBuilder Convert1s(int season);
		IConvert2LeadersRequestBuilder Convert2s(int season);
		IFieldGoalsLeadersRequestBuilder FieldGoals(int season);
		IFieldGoalMissedReturnYardsLeadersRequestBuilder FieldGoalMissedReturnYards(int season);
		IFumblesForcedLeadersRequestBuilder FumblesForced(int season);
		IFumblesRecoveriesLeadersRequestBuilder FumblesRecoveries(int season);
		IInterceptionsLeadersRequestBuilder Interceptions(int season);
		IKickoffYardsLeadersRequestBuilder KickoffYards(int season);
		IKicksBlockedLeadersRequestBuilder KicksBlocked(int season);
		IKickoffReturnYardsLeadersRequestBuilder KickoffReturnYards(int season);
		IPassingTouchdownsLeadersRequestBuilder PassingTouchdowns(int season);
		IPassingYardsLeadersRequestBuilder PassingYards(int season);
		IReceivingTouchdownsLeadersRequestBuilder ReceivingTouchdowns(int season);
		IReceivingYardsLeadersRequestBuilder ReceivingYards(int season);
		IReceivingCaughtLeadersRequestBuilder ReceivingCaught(int season);
		IReceivingTargetedLeadersRequestBuilder ReceivingTargeted(int season);
		IRushingTouchdownsLeadersRequestBuilder RushingTouchdowns(int season);
		IRushingYardsLeadersRequestBuilder RushingYards(int season);
		ISacksLeadersRequestBuilder Sacks(int season);
		ITacklesDefensiveLeadersRequestBuilder TacklesDefensive(int season);
		ITacklesSpecialTeamsLeadersRequestBuilder TacklesSpecialTeams(int season);
		IOffenceLeadersRequestBuilder Offence(int season);
		IDefenceLeadersRequestBuilder Defence(int season);
		ISpecialTeamsLeadersRequestBuilder SpecialTeams(int season);
	}
}