using System;
using System.Linq;

namespace PluralsightInterviewProblems.WordScorer.ScoringStrategies
{
    /*
    Score = sum { score of a letter from string }
    F = 3, J = 6, X = 12, A,I,E,O = 2, T = 5, other letters = 0.
    */
    public class SwitchBasedWordScoringStrategy : IWordScoringStrategy
    {
        public int Score(string stringToScore)
        {
            if(stringToScore == null)
                throw new ArgumentNullException(nameof(stringToScore));

            var scores = stringToScore //"string"
                .ToList() //"s","t","r","i","n","g"
                .Select(LetterScore); // 0, 5, ...

            return scores.Sum(); // sum ( 0 , 5 ... )
        }

        private static int LetterScore(char letter)
        {
            letter = char.ToUpper(letter);
            switch (letter)
            {
                case 'A':
                case 'I':
                case 'E':
                case 'O':
                    return 2;
                case 'F':
                    return 3;
                case 'J':
                    return 6;
                case 'X':
                    return 12;
                case 'T':
                    return 5;
            }
            return 0;
        }
    }
}