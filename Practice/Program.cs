namespace Practice;
class Program
{
    private const int _screenY = 25, _screenX = 80;
    private const int _fieldBoardSize = 1;
    static void Main(string[] args)
    {

        Racket rackets = new();
        Ball ball = new();
        Score score = new();

        score.leftPlayerScore = 0;
        score.rightPlayerScore = 0;

        rackets.size = 6;
        rackets.leftCord = 4;
        rackets.rightCord = 5;
        
        ball.cordX = 15;
        ball.cordY = 15;
        ball.vectorX = -1;
        ball.vectorY = -1;

        while (true)
        {
            Print.PrintFieldGraphic(ball, rackets, _screenX, _screenY);
            Print.PrintPlayersScore(score);
            var userInput = Console.ReadKey(true);
            if (userInput.Key == ConsoleKey.Q) break;
            RacketControl.MoveRacketControl(ref rackets, userInput.Key, _screenY, _fieldBoardSize);
            BallControl.BallController(ref ball, rackets, _screenX, _screenY);
            if (Scoring.IsScoring(ball, ref score, _screenX)) BallControl.BallRestart(ref ball, _screenX, _screenY);
            if (Scoring.IsWining(score)) break;
        }
        
    }
}



