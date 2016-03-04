using PluralsightInterviewProblems.WordScorer.ScoringStrategies;

namespace PluralsightInterviewProblems.Tests.WordScorer
{
    public class SwitchBasedWordScoringStrategyTests : BaseWordScoringStrategyTests
    {
        public SwitchBasedWordScoringStrategyTests() 
            : base(new SwitchBasedWordScoringStrategy())
        {}
    }
}
