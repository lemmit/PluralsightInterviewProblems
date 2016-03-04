using PluralsightInterviewProblems.WordScorer.ScoringStrategies;

namespace PluralsightInterviewProblems.Tests.WordScorer
{
    public class RulesCollectionBasedWordScoringStrategyTests : BaseWordScoringStrategyTests
    {
        public RulesCollectionBasedWordScoringStrategyTests() 
            : base(new RulesCollectionBasedWordScoringStrategy())
        {}
    }
}
