using System;
using NUnit.Framework;
using PluralsightInterviewProblems.WordScorer;

namespace PluralsightInterviewProblems.Tests.WordScorer
{


    [TestFixture]
    public abstract class BaseWordScoringStrategyTests
    {
        readonly IWordScoringStrategy _wordScoringStrategy;
        protected BaseWordScoringStrategyTests(IWordScoringStrategy wordScoringStrategy)
        {
            _wordScoringStrategy = wordScoringStrategy;
        }

        [Test]
        public void For_Empty_String_Score_Is_Zero()
        {
            Assert.AreEqual(_wordScoringStrategy.Score(""), 0);
        }

        [Test]
        public void For_String_With_Only_Whitespaces_Score_Is_Zero()
        {
            Assert.AreEqual(_wordScoringStrategy.Score(" \t\n\r"), 0);
        }

        [Test]
        public void For_Null_String_Expect_NullPtrException()
        {
            Assert.Throws<ArgumentNullException>(
                    () => _wordScoringStrategy.Score(null)
                );
        }

        [Test]
        [TestCase("XRay Machine", 20)]
        [TestCase("Jabbt", 13)]
        public void For_String_X_Score_Is_Y(string str, int score)
        {
            Assert.AreEqual(score, _wordScoringStrategy.Score(str));
        }
    }
}