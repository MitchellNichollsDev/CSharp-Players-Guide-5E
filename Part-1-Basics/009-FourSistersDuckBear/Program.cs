Console.WriteLine("How Many Chocolate eggs were gathered today?");
string numberOfChocolateEggsText = Console.ReadLine();

// Converting User Input to Int Value for division equation 
int numberOfChocolateEggs = Convert.ToInt32(numberOfChocolateEggsText);

// Division for Eggs for Each sister (4 = No of Sisters)
int numberOfEggsForEachSister = numberOfChocolateEggs / 4;

// Modulus for finding the remainder of eggs no split between sisters.
int numberOfEggsForDuckBear = numberOfChocolateEggs % 4;

Console.WriteLine($"Each Sister gets {numberOfEggsForEachSister} Chocolate Eggs.");
Console.WriteLine($"The Duckbear gets {numberOfEggsForDuckBear} Chocolate Eggs.");
