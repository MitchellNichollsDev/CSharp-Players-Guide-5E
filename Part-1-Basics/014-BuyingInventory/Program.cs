Console.Title = "Buying Inventory";

float itemCost;
float discountAmount = 1f;
string myName = "Mitchell";

// Inventory display in the console
Console.WriteLine("The following items are in stock: " +
    "\n1 - Rope" +
    "\n2 - Torches" +
    "\n3 - Climbing Equipment" +
    "\n4 - Clean Water" +
    "\n5 - Machete" +
    "\n6 - Canoe" +
    "\n7 - Food Supplies");

Console.WriteLine("Enter a Number in the menu:");

int inventoryChoice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your name?");    
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
string theirName = Console.ReadLine();

Console.ResetColor();

if(theirName == myName)
{
    Console.WriteLine("Here is your 50% discount.");
    discountAmount = .5f;
}

switch (inventoryChoice)
{
    case 1:
        itemCost = 10 * discountAmount;
        Console.WriteLine($"Rope costs {itemCost} Gold.");
        break;
    case 2:
        itemCost = 15 * discountAmount;
        Console.WriteLine($"Torches cost {itemCost} Gold.");
        break;
    case 3:
        itemCost = 25 * discountAmount;
        Console.WriteLine($"Climbing Equipment costs {itemCost} Gold.");
        break;
    case 4:
        itemCost = 1 * discountAmount;
        Console.WriteLine($"Clean Water costs {itemCost} Gold.");
        break;
    case 5:
        itemCost = 20 * discountAmount;
        Console.WriteLine($"Machete costs {itemCost} Gold.");
        break;
    case 6:
        itemCost = 200 * discountAmount;
        Console.WriteLine($"Canoe costs {itemCost} Gold.");
        break;
    case 7:
        itemCost = 1 * discountAmount;
        Console.WriteLine($"Food Supplies cost {itemCost} Gold.");
        break;
}