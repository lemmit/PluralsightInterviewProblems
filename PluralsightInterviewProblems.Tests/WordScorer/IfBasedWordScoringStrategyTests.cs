using PluralsightInterviewProblems.WordScorer;
using PluralsightInterviewProblems.WordScorer.ScoringStrategies;

namespace PluralsightInterviewProblems.Tests.WordScorer
{
    public class IfBasedWordScoringStrategyTests : BaseWordScoringStrategyTests
    {
        public IfBasedWordScoringStrategyTests() 
            : base(new IfBasedWordScoringStrategy())
        {}
    }
}
