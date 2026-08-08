Console.Title = "Defense of Consolas";

// TARGET ROW CODE -- COLLECT AND CONVERT USER INPUT TO FLOAT
Console.Write("Target Row? ");
string targetRowText = Console.ReadLine();
float targetRow = Convert.ToInt32(targetRowText);

// TARGET COLUMN CODE -- COLLECT AND CONVERT USER INPUT TO FLOAT
Console.Write("Target Column? ");
string targetColumnText = Console.ReadLine();
float targetColumn = Convert.ToInt32(targetColumnText);

// Play Sound for computing results for barriers
Console.Beep(440, 500);

// Change the colour of computed results when displayed for clarity 
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;

// Write Results to the console.
Console.WriteLine($"\nDeploy To:\nNorth Barrier: ({targetRow + 1}, {targetColumn})\nEast Barrier:({targetRow}, {targetColumn + 1})\nSouth Barrier: ({targetRow - 1}, {targetColumn})\nWest Barrier: ({targetRow}, {targetColumn - 1})");

Console.WriteLine("Press any key to proceed...");
Console.ReadKey(true);