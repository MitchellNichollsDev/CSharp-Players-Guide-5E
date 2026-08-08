Console.WriteLine("What kind of thing are we talking about?");

// Defines the noun we will use for the description of the ThingNamer3000
string a = Console.ReadLine(); 
Console.WriteLine("How would you like to describe it? Big? Azure? Tattered?");

// Defines the adjective we will use for the description of the ThingNamer3000
string b = Console.ReadLine();

/* Pre-defined values for the ThingNamer3000, never changed unless values redefined in the code */
string c = "Doom";
string d = "3000";

// Printing the final name of the ThingNamer3000 
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
