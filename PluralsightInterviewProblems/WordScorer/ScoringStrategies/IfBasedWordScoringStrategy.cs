using System;
using System.Linq;

namespace PluralsightInterviewProblems.WordScorer.ScoringStrategies
{
    /*
    Score = sum { score of a letter from string }
    F = 3, J = 6, X = 12, A,I,E,O = 2, T = 5, other letters = 0.
    */
    public class IfBasedWordScoringStrategy : IWordScoringStrategy
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
            if (letter == 'A'
                || letter == 'I'
                || letter == 'E'
                || letter == 'O'
                ) return 2;
            if (letter == 'F') return 3;
            if (letter == 'J') return 6;
            if (letter == 'X') return 12;
            if (letter == 'T') return 5;

            return 0;
        }
    }
}