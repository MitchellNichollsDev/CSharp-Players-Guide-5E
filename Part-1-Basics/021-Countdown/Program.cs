Console.Title = "Countdown";

//for (int x = 10; x > 0; x--)
//    Console.WriteLine(x);

CountdownFactorial(10);
int CountdownFactorial(int x)
{
    if (x <= 0) return 1;
    Console.WriteLine(x);
    return CountdownFactorial(x - 1);
}