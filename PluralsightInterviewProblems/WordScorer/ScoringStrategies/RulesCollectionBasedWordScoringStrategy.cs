using System;
using System.Collections.Generic;
using System.Linq;

namespace PluralsightInterviewProblems.WordScorer.ScoringStrategies
{
    /*
    Score = sum { score of a letter from string }
    F = 3, J = 6, X = 12, A,I,E,O = 2, T = 5, other letters = 0.
    */

    interface IRuleHandler
    {
        bool CanHandle(char letter);
        int Handle(char letter);
    }

    class RuleHandler : IRuleHandler
    {
        private readonly Func<char, bool> _canHandle;
        private readonly Func<char, int> _handle;

        public RuleHandler(System.Func<char, bool> canHandle, System.Func<char, int> handle)
        {
            if (canHandle == null)
                throw new ArgumentNullException(nameof(canHandle));
            if (handle == null)
                throw new ArgumentNullException(nameof(handle));

            _canHandle = canHandle;
            _handle = handle;
        }
        public bool CanHandle(char letter)
        {
            return _canHandle(letter);
        }

        public int Handle(char letter)
        {
            return _handle(letter);
        }
    }

    public class RulesCollectionBasedWordScoringStrategy : IWordScoringStrategy
    {
        
private readonly IList<IRuleHandler>  _scoringHandlers
    = new List<IRuleHandler>()
    {
        new RuleHandler(c => c=='A' || c=='I' || c=='E' || c=='O', c => 2),
        new RuleHandler(c => c=='F', c => 3),
        new RuleHandler(c => c=='J', c => 6),
        new RuleHandler(c => c=='X', c => 12),
        new RuleHandler(c => c=='T', c => 5),
        new RuleHandler(c => true, c => 0),
    };

        public int Score(string stringToScore)
        {
            if(stringToScore == null)
                throw new ArgumentNullException(nameof(stringToScore));

            var scores = stringToScore //"string"
                .ToList() //"s","t","r","i","n","g"
                .Select(LetterScore); // 0, 5, ...
            return scores.Sum(); // sum ( 0 , 5 ... )
        }

        private int LetterScore(char letter)
        {
            letter = char.ToUpper(letter);
            //find 1st that can handle, and get score
            return _scoringHandlers
                        .First(handler => handler.CanHandle(letter))
                        .Handle(letter);
        }
    }
}