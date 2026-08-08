Console.Title = "Watchtower";

// X-Value Collation and conversion of user input
Console.WriteLine("Enter an X Value.");
string xUserValueText = Console.ReadLine();
int xUserValue = Convert.ToInt32(xUserValueText);

// Y-Value Collation and conversion of user input
Console.WriteLine("Enter a Y value.");
string yUserValueText = Console.ReadLine();
int yUserValue = Convert.ToInt32(yUserValueText);

// Row 1 - North-East, North and North-East
if (xUserValue < 0 && yUserValue > 0)
    Console.WriteLine("The enemy is to the North-West");
else if (xUserValue == 0 && yUserValue > 0 )
    Console.WriteLine("The enemy is to the North");
else if (xUserValue > 0 && yUserValue > 0)
    Console.WriteLine("The enemy is to the North-East");

// Row 2 - West, Here and East
else if (xUserValue < 0 && yUserValue == 0)
    Console.WriteLine("The enemy is to the West");
else if (xUserValue == 0 && yUserValue == 0)
    Console.WriteLine("The enemy is here!");
else if (xUserValue > 0 && yUserValue == 0)
    Console.WriteLine("The enemy is to the East");

// Row 3 - South-East, South and South-West
else if (xUserValue < 0 && yUserValue < 0)
    Console.WriteLine("The enemy is to the South-West");
else if (xUserValue == 0 && yUserValue < 0)
    Console.WriteLine("The enemy is to the South");
else
    Console.WriteLine("The enemy is to the South-East");