namespace Practice;
class Program
{
    private const int _screenY = 25, _screenX = 80;
    static void Main(string[] args)
    {
        Racket rackets = new();
        Ball ball = new();

        rackets.leftCord = 4;
        rackets.rightCord = 5;
        ball.cordX = 15;
        ball.cordY = 15;
        var userInput = Console.ReadKey(true);
        while (userInput.Key != ConsoleKey.Q)
        {
            PrintField.PrintFieldGraphic(ball, rackets, _screenX, _screenY);
            userInput = Console.ReadKey(true);
            RacketControl.MoveRacketControl(rackets, userInput.Key, _screenY);

        }
        
    }
}



