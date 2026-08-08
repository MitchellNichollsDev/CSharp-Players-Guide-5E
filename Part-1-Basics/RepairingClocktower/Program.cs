Console.WriteLine("Enter a Whole Number");
string userNumberText = Console.ReadLine();
int userNumber = Convert.ToInt32(userNumberText);

if(userNumber % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}    