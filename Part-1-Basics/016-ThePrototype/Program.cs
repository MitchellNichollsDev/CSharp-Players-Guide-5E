int userOneNumber;
int userTwoNumber;

// User One's while loop - Conditions set for when they choose a number out of the range of 0-100. Their valid choice is cleared out of the console to hide it from User Two.
while(true)
{
    Console.WriteLine("User 1, enter a number between 0 and 100: ");
    string userOneNumberText = Console.ReadLine();
    userOneNumber = Convert.ToInt32(userOneNumberText);

    if (userOneNumber >= 0 && userOneNumber <= 100)
    {
        Console.Clear();
        break;
    }

    Console.WriteLine("User One's number is out of range. Try again.");
}
    Console.WriteLine("User 2, guess the number.");


// User Two's While loop - Conditions for guessing smaller, larger or exactly User One's choice while also choosing out of the range.
while (true)
{
    Console.WriteLine("What is your next guess? ");
    string userTwoNumberText = Console.ReadLine();
    userTwoNumber = Convert.ToInt32(userTwoNumberText);

    if (userTwoNumber < userOneNumber)
    {
        Console.WriteLine($"Your guess is smaller than User One's Choice of Number.");
        continue;
    }
    else if (userTwoNumber > userOneNumber)
    {
        Console.WriteLine($"Your guess is larger than User One's Choice of Number.");
        continue;
    }
    else if (userTwoNumber > 100 || userTwoNumber < 0)
    {
        Console.WriteLine($"Your guess of {userTwoNumber} is out of range of 0-100. Try again.");
        continue;
    }
    else
    {
        Console.WriteLine($"Your guess of {userTwoNumber} is correct.");
        break;
    }
}

