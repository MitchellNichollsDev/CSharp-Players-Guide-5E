Console.Title = "The Magic Cannon";

int maxCranks = 100;

for (int crankTurns = 1; crankTurns <= maxCranks; crankTurns++)
{
    if (crankTurns % 15 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{crankTurns}: Combined Blast");
    }
    else if (crankTurns % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{crankTurns}: Fire");
    }
    else if (crankTurns % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{crankTurns}: Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{crankTurns}: Normal");
    }
    Console.ResetColor();
}