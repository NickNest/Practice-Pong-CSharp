using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Scoring
    {
        public static void IsScoring(Ball ball, ref Score score, int screenX)
        {
            if (ball.cordX == 1) score.rightPlayerScore++;
            if (ball.cordX == screenX - 2) score.leftPlayerScore++;
        }
        public static bool IsWining(Score score)
        {
            return score.leftPlayerScore == 1 || score.rightPlayerScore == 1;
        }
    }
}
