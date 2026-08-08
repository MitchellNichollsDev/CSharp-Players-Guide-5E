Console.WriteLine("Welcome to the Triangle Converter!");

Console.WriteLine("Please enter the base of your triangle.");

// Reading User Input for the triangle base value
string triangleBaseText = Console.ReadLine();

// Converting base value to int for area equation use
float triangleBase = Convert.ToInt32(triangleBaseText);

Console.WriteLine("Please enter the height of your triangle.");

// Reading User Input for the triangle height value
string triangleHeightText = Console.ReadLine();

// Converting height value to int for area equation use
float triangleHeight = Convert.ToInt32(triangleHeightText);

// Area Equation - Base * height / 2
float triangleArea = (triangleBase * triangleHeight) / 2;
Console.WriteLine("Your triangle's area is " + triangleArea);
