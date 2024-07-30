namespace Practice
{
    internal class BallControl
    {
        public static void BallController(ref Ball ball, Racket rackets, int screenX, int screenY)
        {
            if (ball.cordX == 2 && ball.cordY >= rackets.leftCord && ball.cordY < rackets.leftCord + rackets.size) ball.vectorX *= -1;
            else if (ball.cordX == screenX - 3 && ball.cordY >= rackets.rightCord && ball.cordY < rackets.rightCord + rackets.size) ball.vectorX *= -1;
            if (ball.cordY == 1) ball.vectorY *= -1;
            else if (ball.cordY == screenY - 2) ball.vectorY *= -1;
            BallMove(ref ball);
        }
        public static void BallMove(ref Ball ball)
        {
            ball.cordX += ball.vectorX;
            ball.cordY += ball.vectorY;
        }
        public static void BallRestart(ref Ball ball, int screenX, int screenY)
        {
            ball.cordX = screenX / 2;
            ball.cordY = screenY / 2;
            ball.vectorX *= -1; 
            ball.vectorY *= -1;
        }
    }
}
