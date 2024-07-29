namespace Practice;
class Program
{
    private const int _screenY = 25, _screenX = 80;
    private const int _fieldBoardSize = 1;
    static void Main(string[] args)
    {

        Racket rackets = new();
        Ball ball = new();

        rackets.size = 6;
        rackets.leftCord = 4;
        rackets.rightCord = 5;
        
        ball.cordX = 15;
        ball.cordY = 15;
        ball.vectorX = -1;
        ball.vectorY = -1;

        var userInput = Console.ReadKey(true);
        while (userInput.Key != ConsoleKey.Q)
        {
            PrintField.PrintFieldGraphic(ball, rackets, _screenX, _screenY);
            userInput = Console.ReadKey(true);
            RacketControl.MoveRacketControl(ref rackets, userInput.Key, _screenY, _fieldBoardSize);
            BallControl.BallController(ref ball, rackets, _screenX, _screenY);
        }
        
    }
}



