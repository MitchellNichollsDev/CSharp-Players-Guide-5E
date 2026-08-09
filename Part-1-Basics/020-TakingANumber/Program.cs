Console.Title = "Taking A Number";

int result = AskForNumber("What is the airspeed of velocity of an unladen swallow? ");
int AskForNumber(string text)
{
    Console.WriteLine(text);
    string numberText = Console.ReadLine();
    int number = Convert.ToInt32(numberText);
    return number;
}

int rangeResult = AskForNumberInRange($"Please enter a number: ", 10, 30);
int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.WriteLine(text);
        string numberRangeText = Console.ReadLine();
        int numberRange = Convert.ToInt32(numberRangeText);

        if (numberRange >= min && numberRange <= max)
            return numberRange;
        else
        {
            Console.WriteLine($"Number is out of range between {min} and {max}  Please try again.");
            continue;
        }
    }
}