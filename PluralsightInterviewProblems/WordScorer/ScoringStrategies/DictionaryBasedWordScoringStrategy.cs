using System;
using System.Collections.Generic;
using System.Linq;

namespace PluralsightInterviewProblems.WordScorer.ScoringStrategies
{
    /*
    Score = sum { score of a letter from string }
    F = 3, J = 6, X = 12, A,I,E,O = 2, T = 5, other letters = 0.
    */
    public class DictionaryBasedWordScoringStrategy : IWordScoringStrategy
    {
        IDictionary<char, int> _letterScores
            = new Dictionary<char, int>()
            {
                { 'A', 2 },
                { 'I', 2 },
                { 'E', 2 },
                { 'O', 2 },
                { 'F', 3 },
                { 'J', 6 },
                { 'X', 12 },
                { 'T', 5 },
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
            int letterScore;
            return (_letterScores.TryGetValue(letter, out letterScore)) ? letterScore : 0;
        }
    }
}