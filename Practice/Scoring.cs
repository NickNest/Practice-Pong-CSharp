using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Scoring
    {
        public static bool IsScoring(Ball ball, ref Score score, int screenX)
        {
            if (ball.cordX == 1)
            {
                score.rightPlayerScore++;
                return true;
            }
            else if (ball.cordX == screenX - 2)
            {
                score.leftPlayerScore++;
                return true;
            }
            return false;
        }
        public static bool IsWining(Score score)
        {
            return score.leftPlayerScore == 10 || score.rightPlayerScore == 10;
        }
    }
}
