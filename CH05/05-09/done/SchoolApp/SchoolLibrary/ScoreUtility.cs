using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ScoreUtility
    {
        public static IScored BestOfTwo(IScored Assignment1, IScored Assignment2)
        {
            var score1 = Assignment1.Score / Assignment1.MaximumScore;
            var score2 = Assignment2.Score / Assignment2.MaximumScore;

            if(score1 > score2)
            {
                return Assignment1;
            } else
            {
                return Assignment2;
            }
        }
    }
}
