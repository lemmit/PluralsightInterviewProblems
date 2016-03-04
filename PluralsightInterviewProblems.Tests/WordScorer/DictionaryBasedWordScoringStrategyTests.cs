using PluralsightInterviewProblems.WordScorer.ScoringStrategies;

namespace PluralsightInterviewProblems.Tests.WordScorer
{
    public class DictionaryBasedWordScoringStrategyTests : BaseWordScoringStrategyTests
    {
        public DictionaryBasedWordScoringStrategyTests() 
            : base(new DictionaryBasedWordScoringStrategy())
        {}
    }
}
